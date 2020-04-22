using FrameworkWhite.AppFrame;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class ApplicationSteps
    {
        [When(@"I open Paint")]
        public void OpenPaint()
        {
            App.GetInstance();
        }

        [Then(@"Application is open")]
        public void CheckApplicationIsOpen()
        {
            Assert.IsNotNull(App.GetInstance(), "Instance equal null");
            Assert.IsTrue(App.GetInstance().IsWindowVisible, "Window application is not visible");
        }
    }
}
