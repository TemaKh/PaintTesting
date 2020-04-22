using FrameworkWhite;
using FrameworkWhite.Utils.Common;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class ProcessSteps
    {
        [Given(@"All existing open instances of the Paint are closed")]
        public void CloseAllOpenInstancesPaint()
        {
            ProcessUtils.CloseAllProcessesByName(Configuration.ProcessName);
        }
    }
}
