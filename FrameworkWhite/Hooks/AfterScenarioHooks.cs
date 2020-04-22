using FrameworkWhite.AppFrame;
using TechTalk.SpecFlow;

namespace FrameworkWhite.Hooks
{
    [Binding]
    public class AfterScenarioHooks
    {
        [AfterScenario]
        public void CloseApp()
        {
            App.GetInstance().Kill();
        }
    }
}
