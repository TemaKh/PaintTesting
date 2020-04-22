using FrameworkWhite;
using FrameworkWhite.Utils.Common;
using NUnit.Framework;
using PaintTesting.Forms;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class OpeningFromSteps
    {
        private OpeningFromForm openingFrom;

        public OpeningFromSteps(OpeningFromForm openingFrom)
        {
            this.openingFrom = openingFrom;
        }

        [Then(@"Modal window Opening From is open")]
        public void ModalWindowIsOpen()
        {
            Assert.IsTrue(openingFrom.ModalWindowApp.IsModalWindowVisible, 
                $"ModalWindow {openingFrom.ModalWindowApp.Name} is not visible");
        }

        [When(@"I upload '(.*)' using Modal window Opening From")]
        public void UploadAnyPicture(string image)
        {
            openingFrom.EnterFileName(FilePath.GetFilePath(Configuration.FilePath) + image)
                .ClickOpenButton();
        }
    }
}
