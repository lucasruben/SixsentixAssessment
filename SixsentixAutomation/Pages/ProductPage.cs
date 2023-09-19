using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SixsentixAutomation.Pages
{
	internal class ProductPage : BaseWebstoreAppPage
	{
		public ProductPage(IWebDriver driver) : base(driver) { }
		public IWebElement DetailsTab => Driver.FindElement(By.Id("tab-label-description-title"));

		public bool sizeSelected = false;
		public bool colorSelected = false;

		public bool? IsVisible => DetailsTab.Displayed;

		internal void AddToCart()
		{
			var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1));
			wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("product-addtocart-button")));

			Driver.FindElement(By.Id("product-addtocart-button")).Click();
		}

		internal void SelectColor()
		{
			var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1));
			wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='option-label-color-93-item-52']")));

			Driver.FindElement(By.XPath("//div[@id='option-label-color-93-item-52']")).Click();

			colorSelected = true;
		}

		internal void SelectSize()
		{
			var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1));
			wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='option-label-size-143-item-166']")));

			Driver.FindElement(By.XPath("//div[@id='option-label-size-143-item-166']")).Click();

			sizeSelected = true;
		}
	}
}