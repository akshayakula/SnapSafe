using System;
using SnapSafe.Core;

class Program
{
    static void Main()
    {
        string testImage = "../worker.jpg";  // Replace with an actual image path
        string pythonScript = "../SnapSafe.Python/process_image.py";  // Relative path to script

        if (!ImageProcessor.IsValidJpg(testImage))
        {
            Console.WriteLine("Invalid JPG file!");
            return;
        }

        Console.WriteLine("Running Python image processing...");
        string result = PythonRunner.RunPythonScript(pythonScript, testImage);
        Console.WriteLine(result);
    }
}