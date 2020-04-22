using System.Collections.Generic;
using System.Diagnostics;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace FrameworkWhite.Utils.Common
{
    public class ProcessUtils
    {
        public static List<Window> GetWindows()
        {
            return Desktop.Instance.Windows();
        }

        public static void CloseAllProcessesByName(string processWindow)
        {
            Process[] processes = Process.GetProcessesByName(processWindow);
            foreach (Process process in processes)
            {
                process.Kill();
            }
            LoggerUtil.Info($"Close all existing open instances");
        }

        public static bool IsProcessOpen(string processName)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.Contains(processName))
                {
                    return true;
                }
            }
            return false;
        }
    }
}