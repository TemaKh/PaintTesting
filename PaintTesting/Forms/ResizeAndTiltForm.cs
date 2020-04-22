using FrameworkWhite.AppFrame;
using FrameworkWhite.Elements;
using FrameworkWhite.Utils.Common;
using TestStack.White.UIItems.Finders;

namespace PaintTesting.Forms
{
    public class ResizeAndTiltForm
    {
        public ModalWindowApp ModalWindowApp => new ModalWindowApp("Resize and Skew".Translate());
        private TextBox Vertical => new TextBox(SearchCriteria.ByAutomationId("1020"), "Vertical", ModalWindowApp.ModalWindow);
        private TextBox Horizontal => new TextBox(SearchCriteria.ByAutomationId("1019"), "Horizontal", ModalWindowApp.ModalWindow);
        private Button OK => new Button(SearchCriteria.ByAutomationId("1"), "OK", ModalWindowApp.ModalWindow);

        public ResizeAndTiltForm UnSelectCheckBox(string nameCheckBox)
        {
            new CheckBox(SearchCriteria.ByText(nameCheckBox), nameCheckBox, ModalWindowApp.ModalWindow).UnSelect();
            return this;
        }

        public ResizeAndTiltForm EnterVertical(int vertical)
        {
            Vertical.Enter(vertical.ToString());
            return this;
        }

        public ResizeAndTiltForm EnterHorizontal(int horizontal)
        {
            Horizontal.Enter(horizontal.ToString());
            return this;
        }

        public void ClickOKButton()
        {
            OK.Click();
        }
    }
}
