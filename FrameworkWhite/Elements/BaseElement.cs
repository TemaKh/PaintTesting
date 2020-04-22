using FrameworkWhite.AppFrame;
using FrameworkWhite.Utils.Common;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace FrameworkWhite.Elements
{
    public abstract class BaseElement<T> where T : UIItem
    {
        protected string elementName;
        protected SearchCriteria searchCriteria;
        protected Window window;
        public BaseElement(SearchCriteria searchCriteria, string elementName, Window window = null)
        {
            this.elementName = elementName;
            this.searchCriteria = searchCriteria;
            this.window = window == null ? App.GetInstance().Window : window;
        }

        public virtual string GetText()
        {
            return Element.Name;
        }

        public virtual void Click()
        {
            LoggerUtil.Info($"Click: {Element.Name}");
            Element.Click();
        }

        protected T Element
        {
            get
            {
                window.WaitWhileBusy();
                T element = window.Get<T>(searchCriteria);
                LoggerUtil.Info($"Element: {element.Name} is found");
                return element;
            }
        }

        public void RaiseClickEvent()
        {
            LoggerUtil.Info($"Click: {Element.Name}");
            Element.RaiseClickEvent();
        }
    }
}
