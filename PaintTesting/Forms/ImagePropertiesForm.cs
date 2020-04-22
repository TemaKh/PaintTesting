using FrameworkWhite.AppFrame;
using FrameworkWhite.Elements;
using FrameworkWhite.Utils.Common;
using TestStack.White.UIItems.Finders;

namespace PaintTesting.Forms
{
    public class ImagePropertiesForm
    {
        public ModalWindowApp ModalWindowApp => new ModalWindowApp("Image Properties".Translate());
        private TextBox Width => new TextBox(SearchCriteria.ByAutomationId("264"), "Width", ModalWindowApp.ModalWindow);
        private TextBox Height => new TextBox(SearchCriteria.ByAutomationId("266"), "Height", ModalWindowApp.ModalWindow);
        private Button OK => new Button(SearchCriteria.ByAutomationId("1"), "OK", ModalWindowApp.ModalWindow);

        public ImagePropertiesForm ClickRadioButton(string nameRadioButton)
        {
            new RadioButton(SearchCriteria.ByText(nameRadioButton), nameRadioButton, ModalWindowApp.ModalWindow).Click(); 
            return this;
        }

        public void ClickOKButton()
        {
            OK.Click();
        }

        public ImagePropertiesForm EnterWidth(int width)
        {
            Width.Enter(width.ToString());
            return this;
        }

        public ImagePropertiesForm EnterHeight(int height)
        {
            Height.Enter(height.ToString());
            return this;
        }
    }
}
