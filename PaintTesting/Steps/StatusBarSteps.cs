using FrameworkWhite.Utils.Common;
using NUnit.Framework;
using PaintTesting.Forms;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class StatusBarSteps
    {
        private StatusBarForm statusBar;

        public StatusBarSteps(StatusBarForm statusBar)
        {
            this.statusBar = statusBar;
        }

        [Then(@"The size image has changed correctly - '(.*)'x'(.*)' '(.*)'")]
        public void IsSizeHasChangedCorrectly(int width, int height, string units)
        {
            string size = statusBar.GetSize(units.Translate());
            int actualWidth = StringParser.GetWidth(size);
            int actualHeight = StringParser.GetHeight(size);
            Assert.AreEqual(width, actualWidth, $"Expected width: {width} not equal actual width: {actualWidth}");
            Assert.AreEqual(height, actualHeight, $"Expected height: {height} not equal actual height: {actualHeight}");
        }
    }
}
