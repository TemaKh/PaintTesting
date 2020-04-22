using FrameworkWhite.Utils.Common;
using NUnit.Framework;
using PaintTesting.Forms;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class ImagePropertiesSteps
    {
        private ImagePropertiesForm imageProperties;

        public ImagePropertiesSteps(ImagePropertiesForm imageProperties)
        {
            this.imageProperties = imageProperties;
        }

        [When(@"I set the units to '(.*)'")]
        public void SetUnits(string units)
        {
            imageProperties.ClickRadioButton(units.Translate());
        }

        [When(@"I enter width = '(.*)'")]
        public void EnterWidth(int width)
        {
            imageProperties.EnterWidth(width);
        }

        [When(@"I enter height = '(.*)'")]
        public void EnterHeight(int height)
        {
            imageProperties.EnterHeight(height);
        }

        [When(@"I click button OK in Image Properties")]
        public void ClickButtonOK()
        {
            imageProperties.ClickOKButton();
        }

        [Then(@"Image Properties is open")]
        public void ImagePropertiesIsOpen()
        {
            Assert.IsTrue(imageProperties.ModalWindowApp.IsModalWindowVisible, 
                $"ModalWindow {imageProperties.ModalWindowApp.Name} is not visible");
        }
    }
}
