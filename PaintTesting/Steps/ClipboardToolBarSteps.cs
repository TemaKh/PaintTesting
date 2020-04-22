using FrameworkWhite.Utils.Common;
using PaintTesting.Forms;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class ClipboardToolBarSteps
    {
        private ClipboardToolBarForm clipboardToolBar;

        public ClipboardToolBarSteps(ClipboardToolBarForm clipboardToolBar)
        {
            this.clipboardToolBar = clipboardToolBar;
        }

        [When(@"I open modal window Paste From, using the Paste option on the main application screen")]
        public void OpenModalWindowPasteFrom()
        {
            clipboardToolBar.ClickPasteButton()
                .ClickPasteFrom();
        }

        [When(@"I Click '(.*)' in the toolbar clipboard")]
        public void Click(string button)
        {
            clipboardToolBar.ClickButton(button.Translate());
        }
    }
}
