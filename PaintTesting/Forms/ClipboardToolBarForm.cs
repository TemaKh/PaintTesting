using FrameworkWhite.Elements;
using System.Windows.Automation;
using TestStack.White.UIItems.Finders;
using FrameworkWhite.Utils.Common;
using FrameworkWhite.Extensions;
using TestStack.White.UIItems;

namespace PaintTesting.Forms
{
    public class ClipboardToolBarForm
    {
        private UIItem PasteButton => ElementExtensions.FindItemByIndex(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Paste".Translate()), 2);
        private MenuItem PasteFrom => new MenuItem(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Paste from".Translate()), "Paste from");

        public void ClickButton(string name)
        {
            new FrameworkWhite.Elements.Button(SearchCriteria.ByText(name), name).Click();
        }

        public ClipboardToolBarForm ClickPasteButton()
        {
            PasteButton.Click();
            return this;
        }

        public ClipboardToolBarForm ClickPasteFrom()
        {
            PasteFrom.RaiseClickEvent();
            return this;
        }
    }
}
