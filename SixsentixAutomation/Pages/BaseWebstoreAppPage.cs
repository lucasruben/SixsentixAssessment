using OpenQA.Selenium;

namespace SixsentixAutomation.Pages
{
    internal class BaseWebstoreAppPage
    {
        protected IWebDriver Driver { get; set; }

        public BaseWebstoreAppPage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}