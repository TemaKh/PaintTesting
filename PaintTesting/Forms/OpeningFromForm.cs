using FrameworkWhite.AppFrame;
using FrameworkWhite.Elements;
using FrameworkWhite.Utils.Common;
using TestStack.White.UIItems.Finders;

namespace PaintTesting.Forms
{
    public class OpeningFromForm
    {
        public ModalWindowApp ModalWindowApp => new ModalWindowApp(ModalWindowName);
        private TextBox FileName => new TextBox(SearchCriteria.ByAutomationId("1148"), "File name field", ModalWindowApp.ModalWindow);
        private Button Open => new Button(SearchCriteria.ByText("Open".Translate()), "Open button", ModalWindowApp.ModalWindow);

        private string ModalWindowName
        {
            get
            {
                if (string.Equals(LanguageText.Determinet(App.GetInstance().WindowName), "ru")
                || string.Equals(LanguageText.Determinet(App.GetInstance().WindowName), "mix"))
                {
                    return "Открытие";
                }
                return "Open";
            }
        }
        public OpeningFromForm EnterFileName(string fileName)
        {
            FileName.Enter(fileName);
            return this;
        }

        public void ClickOpenButton()
        {
            Open.Click();
        }
    }

}
