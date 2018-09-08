using OpenQA.Selenium;
using SeleniumTest1.Core;
using SeleniumTest1.ObjectRepository;

namespace SeleniumTest1.Action
{
    public class GoogleHomePageAction
    {
        GoogleHomePageObject homePageObject = new GoogleHomePageObject();

        public void SearchKeyword(string keyword)
        {
            BrowserDriver.webDriver.FindElement(homePageObject.SearchField).SendKeys(keyword);
            BrowserDriver.webDriver.FindElement(homePageObject.SearchField).SendKeys(Keys.Enter);
        }

        public int GetNumberOfLinks()
        {
            int numberOfLinks = BrowserDriver.webDriver.FindElements(homePageObject.SearchLinks).Count;
            return numberOfLinks;            
        }

        public string GetLinkTextForIndex(int searchIndex)
        {
            string linkTextForPosition = BrowserDriver.webDriver.FindElements(homePageObject.SearchLinks)[searchIndex -1].Text;
            return linkTextForPosition;
        }
    }
}
