using OpenQA.Selenium;

namespace SeleniumTest1.ObjectRepository
{
    public class GoogleHomePageObject
    {
        public By SearchField => By.Name("q");

        public By SearchLinks => By.CssSelector("div.rc > h3 > a ");
    }
}
