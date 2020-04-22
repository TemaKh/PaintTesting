using FrameworkWhite.AppFrame;
using FrameworkWhite.Elements;
using TestStack.White.UIItems.Finders;

namespace PaintTesting.Forms
{
    public class SaveResultForm
    {
        public ModalWindowApp ModalWindowApp => new ModalWindowApp("Paint");
        private Button DoNotSave => new Button(SearchCriteria.ByAutomationId("CommandButton_7"), "Don't Save", ModalWindowApp.ModalWindow);
                        
        public void ClickDoNotSaveButton()
        {
            DoNotSave.Click();
        }
    }
}
