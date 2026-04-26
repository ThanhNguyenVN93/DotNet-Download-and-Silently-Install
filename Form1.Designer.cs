namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblspeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldownloaded = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.lblPercet = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblpercent = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxversion = new System.Windows.Forms.ComboBox();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.lbllink = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(184, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOTNET DOWNLOADER V1.0\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblspeed);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbldownloaded);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnstart);
            this.groupBox2.Controls.Add(this.lblPercet);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.lblpercent);
            this.groupBox2.Controls.Add(this.lblstatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxversion);
            this.groupBox2.Controls.Add(this.txtlink);
            this.groupBox2.Controls.Add(this.lbllink);
            this.groupBox2.Location = new System.Drawing.Point(1, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblspeed
            // 
            this.lblspeed.AutoSize = true;
            this.lblspeed.Location = new System.Drawing.Point(485, 133);
            this.lblspeed.Name = "lblspeed";
            this.lblspeed.Size = new System.Drawing.Size(42, 13);
            this.lblspeed.TabIndex = 12;
            this.lblspeed.Text = "0 Mb/s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Speed:";
            // 
            // lbldownloaded
            // 
            this.lbldownloaded.AutoSize = true;
            this.lbldownloaded.Location = new System.Drawing.Point(94, 133);
            this.lbldownloaded.Name = "lbldownloaded";
            this.lbldownloaded.Size = new System.Drawing.Size(33, 13);
            this.lbldownloaded.TabIndex = 10;
            this.lbldownloaded.Text = "0 MB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Downloaded:";
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(584, 56);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 8;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lblPercet
            // 
            this.lblPercet.AutoSize = true;
            this.lblPercet.Location = new System.Drawing.Point(502, 66);
            this.lblPercet.Name = "lblPercet";
            this.lblPercet.Size = new System.Drawing.Size(25, 13);
            this.lblPercet.TabIndex = 7;
            this.lblPercet.Text = " 0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 85);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(573, 25);
            this.progressBar1.TabIndex = 6;
            // 
            // lblpercent
            // 
            this.lblpercent.AutoSize = true;
            this.lblpercent.Location = new System.Drawing.Point(62, 57);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(22, 13);
            this.lblpercent.TabIndex = 5;
            this.lblpercent.Text = "???";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(11, 57);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(42, 13);
            this.lblstatus.TabIndex = 4;
            this.lblstatus.Text = "Status:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(380, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Version:";
            // 
            // cbxversion
            // 
            this.cbxversion.FormattingEnabled = true;
            this.cbxversion.Items.AddRange(new object[] {
            "3.5",
            "4.5.2",
            "4.7",
            "4.8"});
            this.cbxversion.Location = new System.Drawing.Point(440, 29);
            this.cbxversion.Name = "cbxversion";
            this.cbxversion.Size = new System.Drawing.Size(147, 21);
            this.cbxversion.Sorted = true;
            this.cbxversion.TabIndex = 2;
            this.cbxversion.SelectedIndexChanged += new System.EventHandler(this.cbxversion_SelectedIndexChanged);
            // 
            // txtlink
            // 
            this.txtlink.Enabled = false;
            this.txtlink.Location = new System.Drawing.Point(50, 29);
            this.txtlink.Name = "txtlink";
            this.txtlink.ReadOnly = true;
            this.txtlink.Size = new System.Drawing.Size(301, 22);
            this.txtlink.TabIndex = 1;
            this.txtlink.TextChanged += new System.EventHandler(this.txtlink_TextChanged);
            // 
            // lbllink
            // 
            this.lbllink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllink.AutoSize = true;
            this.lbllink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllink.ForeColor = System.Drawing.Color.Black;
            this.lbllink.Location = new System.Drawing.Point(11, 29);
            this.lbllink.Name = "lbllink";
            this.lbllink.Size = new System.Drawing.Size(33, 17);
            this.lbllink.TabIndex = 0;
            this.lbllink.Text = "Link:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lblos);
            this.groupBox3.Location = new System.Drawing.Point(1, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 42);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(621, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblos
            // 
            this.lblos.AutoSize = true;
            this.lblos.Location = new System.Drawing.Point(11, 21);
            this.lblos.Name = "lblos";
            this.lblos.Size = new System.Drawing.Size(38, 13);
            this.lblos.TabIndex = 0;
            this.lblos.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 298);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 337);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(685, 337);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNet Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbllink;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxversion;
        private System.Windows.Forms.Label lblPercet;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblpercent;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lbldownloaded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblspeed;
        private System.Windows.Forms.Label lblos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

