using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace FrameworkWhite.Elements
{
    public class MenuItem : BaseElement<Menu>
    {
        public MenuItem(SearchCriteria searchCriteria, string elementName, Window window = null) : base(searchCriteria, elementName, window)
        {

        }
    }
}
