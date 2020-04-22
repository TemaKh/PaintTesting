using FrameworkWhite;
using FrameworkWhite.Utils.Common;
using NUnit.Framework;
using PaintTesting.Forms;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class InsertFromSteps
    {
        private InsertFromForm insertFrom;

        public InsertFromSteps(InsertFromForm insertFrom)
        {
            this.insertFrom = insertFrom;
        }

        [Then(@"Modal window Paste From is open")]
        public void ModalWindowIsOpen()
        {
            Assert.IsTrue(insertFrom.ModalWindowApp.IsModalWindowVisible, 
                $"ModalWindow {insertFrom.ModalWindowApp.Name} is not visible");
        }

        [When(@"I upload '(.*)' using Modal window Paste From")]
        public void UploadAnyPictureUsingPastePasteFrom(string image)
        {
            insertFrom.EnterFileName(FilePath.GetFilePath(Configuration.FilePath) + image)
                .ClickOpenButton();
        }
    }
}
