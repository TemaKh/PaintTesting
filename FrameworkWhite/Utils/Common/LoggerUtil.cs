using NLog;

namespace FrameworkWhite.Utils.Common
{
    public static class LoggerUtil
    {
        private static Logger logger => LogManager.GetCurrentClassLogger();
        public static void Info(string message)
        {
            logger.Info(message);
        }
    }
}
