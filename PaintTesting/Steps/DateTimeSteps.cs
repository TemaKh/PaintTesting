using FrameworkWhite;
using FrameworkWhite.Utils.Common;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class DateTimeSteps
    {
        private ScenarioContext scenarioContext;

        public DateTimeSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [When(@"I get the picture '(.*)' creation date")]
        public void GetCreationDate(string image)
        {
            DateTime CreationTime = new FileInfo(FilePath.GetFilePath(Configuration.FilePath) + image).CreationTime;
            scenarioContext.Add(image, CreationTime);
        }
    }
}
