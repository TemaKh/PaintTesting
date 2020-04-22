using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace FrameworkWhite.Elements
{
    public class Button : BaseElement<TestStack.White.UIItems.Button>
    {
        public Button(SearchCriteria searchCriteria, string elementName, Window window = null) : base(searchCriteria, elementName, window)
        {

        }
    }
}
