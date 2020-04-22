using FrameworkWhite.Utils.Common;
using PaintTesting.Forms;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class PictureToolBarSteps
    {
        private PictureToolBarForm pictureToolBar;

        public PictureToolBarSteps(PictureToolBarForm pictureToolBar)
        {
            this.pictureToolBar = pictureToolBar;
        }

        [When(@"I Click '(.*)' in the picture toolbar")]
        public void ClickButtoInThePictureToolbar(string resize)
        {
            pictureToolBar.ClickButton(resize.Translate());
        }

        [When(@"I click Select All")]
        public void ClickOnAdvancedSelect()
        {
            pictureToolBar.ClickSelectButton()
                .ClickSelectAll();
        }
    }
}
