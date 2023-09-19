using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace SixsentixAutomation
{
	public class WebDriverFactory
	{
		public IWebDriver Create(BrowserType browserType)
		{
			switch (browserType)
			{
				case BrowserType.Chrome:
					return GetChromeDriver();
				default:
					throw new NotImplementedException("Browser type not found.");
			}
		}

		public IWebDriver GetChromeDriver()
		{
			var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			return new ChromeDriver(outPutDirectory);
		}
	}
}
