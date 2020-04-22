using System;
using System.IO;
using System.Reflection;

namespace FrameworkWhite.Utils.Common
{
    public class FilePath
    {
        public static string GetFilePath(string fileName)
        {
            return Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ??
                throw new InvalidOperationException("Unable to find Executing Assembly location"), "TestData",
                fileName);
        }
    }
}
