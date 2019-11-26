using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace FileSystemAgent
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {
            //var service = new ServiceController(serviceInstaller1.ServiceName);
            //if (service.Status != ServiceControllerStatus.Running)
            //{
            //    service.Start();
            //}
        }
    }
}
