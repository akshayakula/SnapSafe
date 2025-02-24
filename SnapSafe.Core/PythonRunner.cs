using System;
using System.Diagnostics;

namespace SnapSafe.Core
{
    public class PythonRunner
    {
        public static string RunPythonScript(string scriptPath, string imagePath)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python3",  // Ensure python3 is installed on Mac
                Arguments = $"{scriptPath} {imagePath}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output;
        }
    }
}