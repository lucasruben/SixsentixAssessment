using AventStack.ExtentReports;
using OpenQA.Selenium.Support.UI;
using SixsentixAutomation.Pages;

namespace SixsentixAutomation.Tests
{
	public class WebstoreAppTest : BaseTest
	{
		[Test, Description("TC41")]
		[Category("UserAuthentication")]
		public void LoginHP()
		{
			var test = extent.CreateTest("TC41");

			var homepage = new Homepage(Driver);

			homepage.GoTo();
			Assert.IsTrue(homepage.IsVisible, "Home page is not visible.");

			var loginPage = homepage.GoToLoginPage();
			Assert.IsTrue(loginPage.IsVisible, "Login page is not visible.");

			var accountPage = loginPage.Login();

			if (!accountPage.IsVisible)
				test.Log(Status.Fail, "Test failed.");
			else
				test.Log(Status.Pass, "Test passed.");

			Assert.IsTrue(accountPage.IsVisible, "Account Page is not visible.");
		}

		[Test, Description("TC02")]
		[Category("Homepage")]
		public void SearchItemHP()
		{
			var test = extent.CreateTest("TC02");

			var homepage = new Homepage(Driver);

			homepage.GoTo();
			Assert.IsTrue(homepage.IsVisible, "Home page is not visible.");

			var loginPage = homepage.GoToLoginPage();
			Assert.IsTrue(loginPage.IsVisible, "Login page is not visible.");

			var accountPage = loginPage.Login();
			Assert.IsTrue(accountPage.IsVisible, "Account Page is not visible.");

			var searchPage = homepage.SearchItem();

			if (!searchPage.IsVisible)
				test.Log(Status.Fail, "Test failed.");
			else
				test.Log(Status.Pass, "Test passed.");

			Assert.IsTrue(searchPage.IsVisible, "Search page is not visible");
		}

		[Test, Description("TC14")]
		[Category("ProductPage")]
		public void AddToCartHP()
		{
			var test = extent.CreateTest("TC14");

			var homepage = new Homepage(Driver);

			homepage.GoTo();
			Assert.IsTrue(homepage.IsVisible, "Home page is not visible.");

			var loginPage = homepage.GoToLoginPage();
			Assert.IsTrue(loginPage.IsVisible, "Login page is not visible.");

			var accountPage = loginPage.Login();
			Assert.IsTrue(accountPage.IsVisible, "Account Page is not visible.");

			var searchPage = homepage.SearchItem();
			Assert.IsTrue(searchPage.IsVisible, "Search page is not visible");

			var productPage = searchPage.GoToFirstItem();

			productPage.SelectSize();
			productPage.SelectColor();

			if (productPage.sizeSelected && productPage.colorSelected)
				productPage.AddToCart();

			var shoppingCart = homepage.GoToCart();

			if (shoppingCart.Empty)
				test.Log(Status.Fail, "Test failed.");
			else
				test.Log(Status.Pass, "Test passed.");

			Assert.IsFalse(shoppingCart.Empty, "Shopping Cart is empty.");
		}
	}
}