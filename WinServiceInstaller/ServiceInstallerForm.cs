using System;
using System.Drawing;
using System.IO;
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
            var cmd = Extension.GetCmd(txtFrameworkPath.Text);

            cmd.Start();

            using (StreamWriter sw = cmd.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                    sw.WriteLine($@"InstallUtil {txtServicePath.Text}");
            }

            cmd.WaitForExit();
            txtLog.Text = cmd.StandardOutput.ReadToEnd();
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            if (txtFrameworkPath.IsEmpty()
                || txtServicePath.IsEmpty())
                return;

            txtLog.Text = "";
            var cmd = Extension.GetCmd(txtFrameworkPath.Text);

            cmd.Start();

            using (StreamWriter sw = cmd.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                    sw.WriteLine($@"InstallUtil -u {txtServicePath.Text}");
            }

            cmd.WaitForExit();
            txtLog.Text = cmd.StandardOutput.ReadToEnd();
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
