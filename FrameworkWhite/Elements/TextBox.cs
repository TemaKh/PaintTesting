using FrameworkWhite.Utils.Common;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace FrameworkWhite.Elements
{
    public class TextBox : BaseElement<TestStack.White.UIItems.TextBox>
    {
        public TextBox(SearchCriteria searchCriteria, string elementName, Window window = null) : base(searchCriteria, elementName, window)
        {

        }

        public void Enter(string value)
        {
            LoggerUtil.Info($"Enter: {value}");
            Element.Enter(value);
        }
    }
}
