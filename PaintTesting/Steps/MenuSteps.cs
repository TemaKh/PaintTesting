using PaintTesting.Forms;
using TechTalk.SpecFlow;

namespace PaintTesting.Steps
{
    [Binding]
    public class MenuSteps
    {
        private MenuForm menu;

        public MenuSteps(MenuForm menu)
        {
            this.menu = menu;
        }

        [When(@"I open Image Properties")]
        public void OpenImageProperties()
        {
            menu.ClickFileButton()
                .ClickMenuProperties();
        }

        [When(@"I open modal window Opening From, using the File tab on the main application screen")]
        public void OpenModalWindowOpeningFrom()
        {
            menu.ClickFileButton()
                .ClickMenuOpen();
        }
    }
}
