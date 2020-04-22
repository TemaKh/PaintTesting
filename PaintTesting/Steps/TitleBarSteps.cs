using PaintTesting.Forms;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class TitleBarSteps
    {
        private TitleBarForm titleBar;

        public TitleBarSteps(TitleBarForm titleBar)
        {
            this.titleBar = titleBar;
        }

        [When(@"I close Paint")]
        public void ClosePaint()
        {
            titleBar.ClickCloseButton();
        }
    }
}
