using NUnit.Framework;
using PaintTesting.Forms;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class SaveResultSteps
    {
        private SaveResultForm saveResult;

        public SaveResultSteps(SaveResultForm saveResult)
        {
            this.saveResult = saveResult;
        }

        [When(@"I refuse to save the result")]
        public void RefuseSaveResult()
        {
            saveResult.ClickDoNotSaveButton();
        }

        [Then(@"A dialog appeared with a proposal to save the results")]
        public void CheckDialogAppearedWithAProposalToSaveTheResults()
        {
            Assert.IsTrue(saveResult.ModalWindowApp.IsModalWindowVisible, 
                $"ModalWindow {saveResult.ModalWindowApp.Name} is not visible");
        }
    }
}
