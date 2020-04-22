using System.Windows.Automation;
using TestStack.White.UIItems.Finders;
using FrameworkWhite.Utils.Common;
using FrameworkWhite.Elements;
using TestStack.White.UIItems;
using FrameworkWhite.Extensions;

namespace PaintTesting.Forms
{
    public class PictureToolBarForm
    {
        private UIItem SelectButton => ElementExtensions.FindItemByIndex(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Select".Translate()), 2);
        private MenuItem SelectAll => new MenuItem(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Select All".Translate()), "Select All");
                
        public PictureToolBarForm ClickSelectButton()
        {
            SelectButton.RaiseClickEvent();
            return this;
        }

        public void ClickSelectAll()
        {
            SelectAll.Click();
        }

        public void ClickButton(string nameButton)
        {
            new FrameworkWhite.Elements.Button(SearchCriteria.ByText(nameButton), nameButton).Click();
        }
    }
}
