using FrameworkWhite.Utils.Common;
using TestStack.White.UIItems.WindowItems;

namespace FrameworkWhite.AppFrame
{
    public class ModalWindowApp
    {
        public ModalWindowApp(string nameModalWindow)
        {
            ModalWindow = App.GetInstance().Window.ModalWindow(nameModalWindow);
            LoggerUtil.Info($"ModalWindow {nameModalWindow} is visible");
        }

        public Window ModalWindow { get; private set; }

        public bool IsModalWindowVisible => ModalWindow.Visible;

        public string Name => ModalWindow.Name;
    }
}
