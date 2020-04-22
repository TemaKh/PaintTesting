using System.Windows.Automation;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace FrameworkWhite.Elements
{
    public class StatusBar : BaseElement<StatusStrip>
    {
        public StatusBar(SearchCriteria searchCriteria, string elementName, Window window = null) : base(searchCriteria, elementName, window)
        {

        }

        public AutomationElementCollection GetElements(TreeScope treeScope, Condition condition)
        {
            return Element.AutomationElement.FindAll(treeScope, condition);
        }
    }
}
