using System;
using System.IO;

namespace SnapSafe.Core
{
    public class ImageProcessor
    {
        public static bool IsValidJpg(string filePath)
        {
            if (!File.Exists(filePath)) return false;

            // Check if the file is a valid JPG based on extension
            return filePath.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                   filePath.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase);
        }
    }
}