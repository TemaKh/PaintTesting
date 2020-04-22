using FrameworkWhite.AppFrame;
using FrameworkWhite.Utils.Common;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Actions;

using TestStack.White.UIItems.WindowItems;

namespace FrameworkWhite.Extensions
{
    public class ElementExtensions
    {
        public static UIItem Find(TreeScope treeScope, AutomationProperty property, object value, Window window = null)
        {
            window = window == null ? App.GetInstance().Window : window;
            var element = new UIItem(window.AutomationElement.FindFirst(treeScope, new PropertyCondition(property, value)), new NullActionListener());
            LoggerUtil.Info($"Element {element.Name} is found");
            return element;
        }

        public static UIItem FindItemByIndex(TreeScope treeScope, Condition condition, int index)
        {
            var elements = App.GetInstance().Window.AutomationElement.FindAll(treeScope, condition);
            UIItem element = null;
            for (var i = 0; i < elements.Count; i++)
            {
                if (i == index)
                {
                    element = new UIItem(elements[i], new NullActionListener());
                }
            }
            LoggerUtil.Info($"Element {element.Name} is found");
            return element;
        }
    }
}
