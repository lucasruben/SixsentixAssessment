using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SixsentixAutomation.Pages
{
	internal class ShoppingCartPage : BaseWebstoreAppPage
	{
		public ShoppingCartPage(IWebDriver driver) : base(driver) { }

		public int CartCount()
		{
			var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1));
			wait.Until(ExpectedConditions.ElementExists(By.ClassName("counter-number")));

			var count = Driver.FindElement(By.ClassName("counter-number")).Text;

			return count == String.Empty ? 0 : int.Parse(count); 
		}

		public bool Empty => CartCount() == 0;
	}
}