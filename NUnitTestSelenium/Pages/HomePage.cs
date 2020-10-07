using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace NUnitTestSelenium.Pages
{
    public class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.Name, Using = "userName")]
        private IWebElement userName;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passWord;

        [FindsBy(How = How.Name, Using = "submit")]
        private IWebElement submitButton;

        public void TypeUserName(string username)
        {
            userName.SendKeys(username);
        }
        public void TypePassword(string password)
        {
            passWord.SendKeys(password);
        }

        public void ClickSubmitButton()
        {
            submitButton.Click();
        }
    }

}