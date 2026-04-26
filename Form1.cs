using AltoHttp;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var os = Environment.OSVersion;

            if (os.Version.Major == 6 && os.Version.Minor == 1 && os.Version.Build == 7600)
            {
                MessageBox.Show("Windows 7 RTM is not supported.\nPlease install Service Pack 1 first.",
                    "Unsupported OS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            lblos.Text = GetOsDisplayName();

            cbxversion.SelectedIndex = 0;
            cbxversion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private string GetOsDisplayName()
        {
            try
            {
                string name = Microsoft.Win32.Registry.GetValue(
                    @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion",
                    "ProductName", "Unknown")?.ToString();
                string build = Microsoft.Win32.Registry.GetValue(
                    @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion",
                    "CurrentBuildNumber", "")?.ToString();
                string arch = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
                return $"OS: {name} (Build {build}) — {arch}";
            }
            catch
            {
                return $"OS: {Environment.OSVersion}";
            }
        }

        private void txtlink_TextChanged(object sender, EventArgs e)
        {
        }

        private string _fileName;

        private void cbxversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxversion.SelectedItem?.ToString())
            {
                case "3.5":
                    txtlink.Text = "https://go.microsoft.com/fwlink/?linkid=2186537";
                    _fileName = "dotnetfx35setup.exe";
                    break;
                case "4.5.2":
                    txtlink.Text = "https://download.microsoft.com/download/e/2/1/e21644b5-2df2-47c2-91bd-63c560427900/NDP452-KB2901907-x86-x64-AllOS-ENU.exe";
                    _fileName = "NDP452-KB2901907-x86-x64-AllOS-ENU.exe";
                    break;
                case "4.7":
                    txtlink.Text = "http://go.microsoft.com/fwlink/?linkid=825302";
                    _fileName = "NDP47-x86-x64-AllOS-ENU.exe";
                    break;
                case "4.8":
                    txtlink.Text = "https://go.microsoft.com/fwlink/?linkid=2088631";
                    _fileName = "ndp48-web.exe";
                    break;
            }
        }

        private HttpDownloader httpdownloader;
        private string _saveDir;
        private string _fullPath;
        private long _lastBytesReceived = 0;
        private DateTime _lastSpeedCheck;

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlink.Text))
            {
                MessageBox.Show("Please select a version first.", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select folder to save the installer";
                dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
                _saveDir = dialog.SelectedPath;
            }

            _fullPath = Path.Combine(_saveDir, _fileName);
            _lastBytesReceived = 0;
            _lastSpeedCheck = DateTime.Now;

            btnstart.Enabled = false;
            cbxversion.Enabled = false;
            lblpercent.Text = "Downloading...";
            lblPercet.Text = "0%";

            httpdownloader = new HttpDownloader(txtlink.Text, _fullPath);
            httpdownloader.ProgressChanged += Httpdownloader_ProgressChanged;
            httpdownloader.DownloadCompleted += Httpdownloader_DownloadCompleted;
            httpdownloader.ErrorOccured += Httpdownloader_ErrorOccured;
            httpdownloader.Start();
        }

        private void Httpdownloader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Httpdownloader_ProgressChanged(sender, e)));
                return;
            }

            DateTime now = DateTime.Now;
            double elapsed = (now - _lastSpeedCheck).TotalSeconds;
            if (elapsed >= 0.5)
            {
                long delta = httpdownloader.TotalBytesReceived - _lastBytesReceived;
                lblspeed.Text = $"{delta / elapsed / 1024d / 1024d:0.00} MB/s";
                _lastBytesReceived = httpdownloader.TotalBytesReceived;
                _lastSpeedCheck = now;
            }

            progressBar1.Value = Math.Min((int)e.Progress, 100);
            lblPercet.Text = $"{e.Progress:0.00}%";
            lbldownloaded.Text = $"{httpdownloader.TotalBytesReceived / 1024d / 1024d:0.00} MB";
        }

        private void Httpdownloader_DownloadCompleted(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Httpdownloader_DownloadCompleted(sender, e)));
                return;
            }

            progressBar1.Value = 100;
            lblPercet.Text = "100%";
            lblpercent.Text = "Installing...";
            lblspeed.Text = "";

            this.Hide();
            RunInstaller();
        }

        private void Httpdownloader_ErrorOccured(object sender, System.IO.ErrorEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Httpdownloader_ErrorOccured(sender, e)));
                return;
            }

            WriteLog($"Download error: {e.GetException()}");
            MessageBox.Show($"Download failed:\n{e.GetException()?.Message}\n\nSee the log file for details.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void RunInstaller()
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = _fullPath,
                    Arguments = "/q /norestart",
                    UseShellExecute = true,
                    Verb = "runas",
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                var process = Process.Start(psi);
                process.EnableRaisingEvents = true;
                process.Exited += (s, ev) =>
                {
                    if (InvokeRequired)
                        Invoke(new Action(() => OnInstallerExited(process.ExitCode)));
                    else
                        OnInstallerExited(process.ExitCode);
                };
            }
            catch (Exception ex)
            {
                WriteLog($"Installer launch error: {ex}");
                MessageBox.Show($"Could not launch installer:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void OnInstallerExited(int exitCode)
        {
            if (exitCode == 0 || exitCode == 3010 || exitCode == 1641)
            {
                string msg = (exitCode == 0)
                    ? ".NET Framework installation complete!"
                    : "Installation complete! Please restart your computer to finish.";
                MessageBox.Show(msg, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                WriteLog($"Installer exited with code: {exitCode}");
                MessageBox.Show($"Installation failed (exit code: {exitCode}).\nSee the log file for details.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }

        private void WriteLog(string content)
        {
            try
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
                string logPath = Path.Combine(
                    _saveDir ?? AppDomain.CurrentDomain.BaseDirectory,
                    $"error at {timestamp}.txt");
                File.WriteAllText(logPath, $"[{DateTime.Now}]\n{content}");
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
