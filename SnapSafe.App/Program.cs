using System;
using SnapSafe.Core;  // Ensure this line is present

class Program
{
    static void Main()
    {
        Console.WriteLine("🚧SnapSafe - AI-Powered Construction Safety 🚧");

        // Test image file path (ensure test.jpg exists)
        string testImage = "./worker.jpg";  // Adjust path if needed
        string pythonScript = "SnapSafe.Python/process_image.py";  // Adjust path if needed

        // Validate the image before processing
        if (!ImageProcessor.IsValidJpg(testImage))
        {
            Console.WriteLine("❌ Invalid JPG file! Ensure the file exists.");
            return;
        }

        Console.WriteLine("🔄 Running Python image processing...");

        // Call Python script to process the image
        string result = PythonRunner.RunPythonScript(pythonScript, testImage);
        Console.WriteLine($"✅ Python Output: {result}");
    }
}