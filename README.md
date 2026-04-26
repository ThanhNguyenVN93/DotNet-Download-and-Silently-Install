# DotNet Downloader

A lightweight Windows Forms tool that downloads and silently installs .NET Framework packages directly on the target machine.

## Features

- Download and install .NET Framework **3.5**, **4.5.2**, **4.7**, or **4.8** with one click
- Real-time download progress bar, percentage, speed, and downloaded size
- Silent installation (no user prompts) with UAC elevation
- Displays current OS name, build number, and architecture
- Payment QR code viewer (MoMo & Techcombank)
- All images embedded in the executable — fully portable, no external files needed
- Rejects Windows 7 RTM (requires SP1 or later)

## Requirements

- Windows 7 SP1 or later (32-bit or 64-bit)
- .NET Framework 4.5.2 to run the tool itself

## Building

1. Open `WindowsFormsApp2.slnx` in **Visual Studio 2022**
2. Restore NuGet packages (right-click solution → Restore NuGet Packages)
3. Build → **Release**

The output executable is in `bin\Release\WindowsFormsApp2.exe`.

## Dependencies

| Package | Version |
|---------|---------|
| [AltoHttp](https://github.com/cemahseri/AltoHttp) | 1.5.2 |
| [Newtonsoft.Json](https://www.newtonsoft.com/json) | 13.0.1 |

## Usage

1. Run `WindowsFormsApp2.exe` as Administrator (or it will request elevation automatically)
2. Select the .NET Framework version from the dropdown
3. Click **START** and choose a folder to save the installer
4. The tool downloads, then silently installs — restart if prompted

## Exit Codes

| Code | Meaning |
|------|---------|
| 0 | Installation successful |
| 3010 | Success — restart required |
| 1641 | Success — restart initiated |
| Other | Installation failed (see error log in save folder) |

## License

[MIT](LICENSE) © 2026 ThanCoder93-VN
