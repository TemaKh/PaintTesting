using FrameworkWhite.Elements;
using FrameworkWhite.Extensions;
using FrameworkWhite.Utils.Common;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace PaintTesting.Forms
{
    public class MenuForm
    {
        private MenuItem MenuProperties => new MenuItem(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Properties".Translate()), "Properties");
        private MenuItem MenuOpen => new MenuItem(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Open".Translate()), "Open");
        private UIItem FileButton => ElementExtensions.Find(TreeScope.Descendants, AutomationElementIdentifiers.NameProperty, "File tab".Translate());

        public MenuForm ClickFileButton()
        {
            FileButton.Click();
            return this;
        }

        public void ClickMenuOpen()
        {
            MenuOpen.RaiseClickEvent();
        }

        public void ClickMenuProperties()
        {
            MenuProperties.RaiseClickEvent();
        }
    }
}
