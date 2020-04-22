using FrameworkWhite.Utils.Common;
using NUnit.Framework;
using PaintTesting.Forms;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class ResizeAndTiltSteps
    {
        private ResizeAndTiltForm resizeAndTilt;

        public ResizeAndTiltSteps(ResizeAndTiltForm resizeAndTilt)
        {
            this.resizeAndTilt = resizeAndTilt;
        }

        [Then(@"Modal window Resize and Skew is open")]
        public void ModalWindowIsOpen()
        {
            Assert.IsTrue(resizeAndTilt.ModalWindowApp.IsModalWindowVisible, 
                $"ModalWindow {resizeAndTilt.ModalWindowApp.Name} is not visible");
        }

        [When(@"I unselect checkbox '(.*)'")]
        public void UnselectCheckbox(string proportions)
        {
            resizeAndTilt.UnSelectCheckBox(proportions.Translate());
        }

        [When(@"I enter '(.*)' in the field vertically")]
        public void EnterValueVertically(int vertical)
        {
            resizeAndTilt.EnterVertical(vertical);
        }

        [When(@"I click button OK in Resize and Skew modal window")]
        public void ClickButtonOK()
        {
            resizeAndTilt.ClickOKButton();
        }
    }
}
