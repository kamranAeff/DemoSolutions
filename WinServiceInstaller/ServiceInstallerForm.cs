using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WinServiceInstaller.Core.Extensions;

namespace WinServiceInstaller
{
    public partial class ServiceInstallerForm : Form
    {
        public ServiceInstallerForm()
        {
            InitializeComponent();

            txtFrameworkPath.Text = Path.Combine(Environment.GetEnvironmentVariable("windir"), @"Microsoft.NET\Framework\v4.0.30319");

        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if (txtFrameworkPath.IsEmpty()
                || txtServicePath.IsEmpty())
                return;

            txtLog.Text = "";
            var procStartInfo = new ProcessStartInfo("cmd");
            var process = new Process();
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.WorkingDirectory = txtFrameworkPath.Text;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            process.StartInfo = procStartInfo;
            process.Start();

            using (StreamWriter sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                    sw.WriteLine($@"InstallUtil {txtServicePath.Text}");
            }

            process.WaitForExit();
            txtLog.Text = process.StandardOutput.ReadToEnd();
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
            var procStartInfo = new ProcessStartInfo("cmd");
            var process = new Process();
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.WorkingDirectory = txtFrameworkPath.Text;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            process.StartInfo = procStartInfo;
            process.Start();

            using (StreamWriter sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                    sw.WriteLine($@"InstallUtil -u {txtServicePath.Text}");
            }

            process.WaitForExit();
            txtLog.Text = process.StandardOutput.ReadToEnd();
        }

        private void btnFrameworkPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFrameworkPath.Text) && Directory.Exists(txtFrameworkPath.Text))
                fbDialog.SelectedPath = txtFrameworkPath.Text;
            else
                fbDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//desktop ünvanini verir

            if (fbDialog.ShowDialog()==DialogResult.OK)
                txtFrameworkPath.Text = fbDialog.SelectedPath;
        }

        private void btnServicePath_Click(object sender, EventArgs e)
        {
            if (ofDialog.ShowDialog() == DialogResult.OK)
                txtServicePath.Text = ofDialog.FileName;
        }

        private void btnInstall_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = ColorTranslator.FromHtml("#2c3e50");
        }

        private void btnInstall_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = ColorTranslator.FromHtml("#2b3b4a");
        }
    }
}
