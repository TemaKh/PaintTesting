using FrameworkWhite.Elements;
using TestStack.White.UIItems.Finders;

namespace PaintTesting.Forms
{
    public class TitleBarForm
    {
        private readonly Button Close = new Button(SearchCriteria.ByAutomationId("Close"), "Close");
                
        public void ClickCloseButton()
        {
            Close.Click();
        }
    }
}
