using OpenQA.Selenium;

namespace SixsentixAutomation.Pages
{
    internal class LoginPage : BaseWebstoreAppPage
    {
        public IWebElement UsernameField => Driver.FindElement(By.Id("email"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("pass"));
        public IWebElement SignInButton => Driver.FindElement(By.Id("send2"));

        private string user = "lucas@mailinator.com";
        private string pwd = "T3stPWD!";

        public LoginPage(IWebDriver driver) : base(driver) { }

        public bool? IsVisible => Driver.Title.Contains("Customer Login");

        internal AccountPage Login()
        {
            UsernameField.SendKeys(user);
            PasswordField.SendKeys(pwd);
            SignInButton.Submit();

            return new AccountPage(Driver);
        }
    }
}