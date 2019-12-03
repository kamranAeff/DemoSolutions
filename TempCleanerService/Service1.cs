using System;
using System.IO;
using System.ServiceProcess;

namespace TempCleanerService
{
    public partial class Service1 : ServiceBase
    {
        const string logPath = "errors.log";
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        public static void OnDebug()
        {
            
            var tempFolder = Path.GetTempPath();

            foreach (var path in Directory.GetFiles(tempFolder))
            {
                try
                {
                    File.Delete(path);
                }
                catch (UnauthorizedAccessException ex)
                {

                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            foreach (var path in Directory.GetDirectories(tempFolder))
            {
                try
                {
                    Directory.Delete(path, true);
                }
                catch (IOException ex)
                {

                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
    }
}
