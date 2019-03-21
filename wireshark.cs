using System;
namespace WireShark
{
class WireShark 
    {
        static void Main(string[] args) 
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/Q /C wireshark.bat " + "\"" + args[0] + "\"";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}