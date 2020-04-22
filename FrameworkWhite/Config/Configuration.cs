using System.Configuration;

namespace FrameworkWhite
{
    public class Configuration
    {
        /// <summary>
        /// get from app.config field ApplicationExePath
        /// </summary>
        public static string ApplicationExePath
        {
            get { return GetValue("ApplicationExePath"); }
        }

        /// <summary>
        /// get from app.config field ProcessName
        /// </summary>
        public static string ProcessName
        {
            get { return GetValue("ProcessName"); }
        }

        /// <summary>
        /// get from app.config field ClassName
        /// </summary>
        public static string ClassName
        {
            get { return GetValue("ClassName"); }
        }

        /// <summary>
        /// get from app.config field FilePath
        /// </summary>
        public static string FilePath
        {
            get { return GetValue("FilePath"); }
        }

        /// <summary>
        /// get from app.config field and converts into string
        /// </summary>
        protected static string GetValue(string key)
        {
            return GetEnviromentVar(key, ConfigurationManager.AppSettings.Get(key));
        }

        /// <summary>
        /// returns value of environment variable
        /// </summary>
        /// <param name="var">variable's name</param>
        /// <param name="defaultValue">default value, will be returned if env var was not setted</param>
        /// <returns>value of environment variable</returns>
        public static string GetEnviromentVar(string var, string defaultValue)
        {
            return System.Environment.GetEnvironmentVariable(var) ?? defaultValue;
        }
    }
}
