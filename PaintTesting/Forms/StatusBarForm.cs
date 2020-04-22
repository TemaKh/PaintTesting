using FrameworkWhite.Elements;
using System.Windows.Automation;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;

namespace PaintTesting.Forms
{
    public class StatusBarForm
    {
        private StatusBar StatusBar => new StatusBar(SearchCriteria.ByClassName("msctls_statusbar32"), "Status bar");
        
        private AutomationElementCollection ElementsStatusBar => StatusBar.GetElements(TreeScope.Children, Condition.TrueCondition);
       
        public string GetSize(string units)
        {
            foreach (AutomationElement element in ElementsStatusBar)
            {
                if (element.Current.Name.Contains(units))
                {
                    return new TestStack.White.UIItems.Label(element, new NullActionListener()).Text;
                }
            }
            return "0,00 × 0,00‏ cm";
        }
    }
}
