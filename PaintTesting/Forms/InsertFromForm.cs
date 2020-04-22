using FrameworkWhite.AppFrame;
using FrameworkWhite.Elements;
using FrameworkWhite.Utils.Common;
using TestStack.White.UIItems.Finders;

namespace PaintTesting.Forms
{
    public class InsertFromForm
    {
        public ModalWindowApp ModalWindowApp => new ModalWindowApp("Paste From".Translate());
        private TextBox FileName => new TextBox(SearchCriteria.ByAutomationId("1148"), "File name field", ModalWindowApp.ModalWindow);
        private Button Open => new Button(SearchCriteria.ByText("Open".Translate()), "Open button", ModalWindowApp.ModalWindow);
       
        public InsertFromForm EnterFileName(string fileName)
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
