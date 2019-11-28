using System.Diagnostics;

namespace WinServiceInstaller.Core.Extensions
{
    static partial class Extension
    {
        static internal Process GetCmd(string workingDirectory)
        {
            var cmd = new Process();
            cmd.StartInfo = new ProcessStartInfo("cmd");
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.WorkingDirectory = workingDirectory;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.CreateNoWindow = true;

            return cmd;
        }
    }
}
