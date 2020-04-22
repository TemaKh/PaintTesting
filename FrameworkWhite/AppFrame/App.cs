using TestStack.White;
using System.Collections.Generic;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.Factory;
using FrameworkWhite.Utils.Common;

namespace FrameworkWhite.AppFrame
{
    public class App
    {
        private static App instance;
        private Application application;

        private App()
        {
            application = Application.Launch(Configuration.ApplicationExePath);
            Window = application.GetWindow(SearchCriteria.ByClassName(Configuration.ClassName), InitializeOption.NoCache);
            WindowName = Window.Name;
            LoggerUtil.Info($"Application is open");
        }

        public static App GetInstance()
        {
            if (instance == null)
            {
                instance = new App();
            }
            return instance;
        }

        public Window Window { get; }

        public string WindowName { get; }

        public List<Window> Windows => application.GetWindows();

        public bool IsWindowVisible => Window.Visible;
        
        public void Kill()
        {
            LoggerUtil.Info($"Killing the app");
            application.Kill();
            instance = null;
        }
    }
}
