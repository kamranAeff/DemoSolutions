using System;
using System.IO;
using System.Security.Permissions;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace FileSystemAgent
{
    public partial class Service1 : ServiceBase
    {
        readonly string logFile = "history.log";
        public Service1()
        {
            InitializeComponent();
            logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,logFile);
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        protected override void OnStart(string[] args)
        {
            Task.Run(delegate {
                fswAgent.EnableRaisingEvents = true;
                fswAgent.WaitForChanged(WatcherChangeTypes.All);
            });
        }

        protected override void OnStop()
        {
            fswAgent.EnableRaisingEvents = false;
        }

        private void fswAgent_Changed(object sender, FileSystemEventArgs e)
        {
            File.AppendAllText(logFile,$"{DateTime.Now:dd.MM.yyyy HH:mm:ss} Changed: \"{e.FullPath}\"; \"{e.ChangeType}\"; \"{e.Name}\"{Environment.NewLine}");
        }

        private void fswAgent_Created(object sender, FileSystemEventArgs e)
        {
            File.AppendAllText(logFile, $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} Created: \"{e.FullPath}\"; \"{e.ChangeType}\"; \"{e.Name}\"{Environment.NewLine}");
        }

        private void fswAgent_Deleted(object sender, FileSystemEventArgs e)
        {
            File.AppendAllText(logFile, $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} Deleted: \"{e.FullPath}\"; \"{e.ChangeType}\"; \"{e.Name}\"{Environment.NewLine}");
        }

        private void fswAgent_Renamed(object sender, RenamedEventArgs e)
        {
            File.AppendAllText(logFile, $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} Renamed: \"{e.OldFullPath} >> {e.FullPath}\"; \"{e.ChangeType}\"; \"{e.OldName} >> {e.Name}\"{Environment.NewLine}");
        }
    }
}
