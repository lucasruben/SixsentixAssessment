using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;

namespace SixsentixAutomation.Tests
{
	public class BaseTest
	{
		internal IWebDriver Driver { get; set; }
		internal ExtentReports extent;

		[OneTimeSetUp]
		public void StartReporter()
		{
			var dir = @"C:\Reports\";

			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);

			extent = new ExtentReports();

			var report = new ExtentSparkReporter(dir + "AutomationReport.html");

			extent.AttachReporter(report);
		}

		[SetUp]
		public void SetupForAllTests()
		{
			var factory = new WebDriverFactory();
			Driver = factory.Create(BrowserType.Chrome);

			Driver.Manage().Window.Maximize();
		}

		[TearDown]
		public void CleanUpAfterAllTests()
		{
			Driver.Close();
			Driver.Quit();
		}

		[OneTimeTearDown]
		public void EndReport()
		{
			extent.Flush();
		}
	}
}
