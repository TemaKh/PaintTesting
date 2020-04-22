using FrameworkWhite;
using FrameworkWhite.Extensions;
using FrameworkWhite.Utils.Common;
using NUnit.Framework;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class PaintTestingSteps
    {
        private ScenarioContext scenarioContext;

        public PaintTestingSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then(@"The original picture '(.*)' has not changed")]
        public void CheckOriginalPictureHasNotChanged(string image)
        {
            DateTime ExpectedCreationTime = scenarioContext.getValue<DateTime>(image);
            DateTime ActualCreationTime = new FileInfo(FilePath.GetFilePath(Configuration.FilePath) + image).CreationTime;
            Assert.AreEqual(ExpectedCreationTime, ActualCreationTime, "The original picture has changed");
        }
    }
}
