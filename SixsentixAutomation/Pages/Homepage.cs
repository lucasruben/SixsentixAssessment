using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SixsentixAutomation.Pages
{
    internal class Homepage : BaseWebstoreAppPage
    {
        public IWebElement SearchField => Driver.FindElement(By.Id("search"));
        public IWebElement SearchButton => Driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/header[1]/div[2]/div[2]/div[2]/form[1]/div[2]/button[1]"));

        private string urlHomepage = "https://magento.softwaretestingboard.com/";
        private string urlLoginPage = "https://magento.softwaretestingboard.com/customer/account/login/referer";
        private string searchString = "Jacket";

        public Homepage(IWebDriver driver) : base(driver) { }

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl(urlHomepage);
        }

        internal LoginPage GoToLoginPage()
        {
            Driver.Navigate().GoToUrl(urlLoginPage);
            return new LoginPage(Driver);
        }

        internal SearchResultsPage SearchItem()
        {
            SearchField.SendKeys(searchString);
            SearchButton.Submit();

            return new SearchResultsPage(Driver);
        }

        internal ShoppingCartPage GoToCart()
        {
			var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//header/div[2]/div[1]/a[1]")));

            Driver.FindElement(By.XPath("//header/div[2]/div[1]/a[1]")).Click();
            
            return new ShoppingCartPage(Driver);
        }

        internal bool? IsVisible => Driver.Title.Contains("Home Page");
    }
}