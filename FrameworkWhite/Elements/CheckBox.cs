using FrameworkWhite.Utils.Common;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace FrameworkWhite.Elements
{
    public class CheckBox : BaseElement<TestStack.White.UIItems.CheckBox>
    {
        public CheckBox(SearchCriteria searchCriteria, string elementName, Window window = null) : base(searchCriteria, elementName, window)
        {

        }

        public void UnSelect()
        {
            LoggerUtil.Info($"UnSelect: {Element.Name}");
            Element.UnSelect();
        }
    }
}
