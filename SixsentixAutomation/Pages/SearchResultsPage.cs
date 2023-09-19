using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SixsentixAutomation.Pages
{
	internal class SearchResultsPage : BaseWebstoreAppPage
    {
        public SearchResultsPage(IWebDriver driver) : base(driver) { }

        public bool IsVisible => Driver.Title.Contains("Search results for: ");
		
        public List<IWebElement> items => Driver.FindElements(By.ClassName("product-item-link")).ToList();

		internal ProductPage GoToFirstItem()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));

            wait.Until(d => items[0].Displayed);

			items[0].Click();

            return new ProductPage(Driver);
        }
    }
}