using OpenQA.Selenium;

namespace SixsentixAutomation.Pages
{
    internal class AccountPage : BaseWebstoreAppPage
    {
        public AccountPage(IWebDriver driver) : base(driver) { }

        public bool IsVisible => Driver.Title.Contains("My Account");

    }
}