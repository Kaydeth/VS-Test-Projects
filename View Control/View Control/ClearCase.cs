using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace View_Control
{
    class ClearCase
    {
        public static void startView(string view_name)
        {
            string cmd = "startview " + view_name;

            executeClearCaseCmd(cmd);
        }

        public static void endView(string view_name)
        {
            string cmd = "endview " + view_name;

            executeClearCaseCmd(cmd);
        }

        private static void executeClearCaseCmd(string cmd)
        {
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "cleartool";
            p.StartInfo.Arguments = cmd;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine(output);
            Console.WriteLine(error);
        }
    }
}
