using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using NLog;
using System.Configuration;
using NUnit.Framework;

namespace NUnitTestSelenium.Pages
{
    public class HomePage
    {

        private IWebDriver driver;
        String baseUrl = ConfigurationManager.AppSettings.Get("BaseURL");
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        [FindsBy(How = How.Name, Using = "userName")]
        private IWebElement userName;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passWord;

        [FindsBy(How = How.Name, Using = "submit")]
        private IWebElement submitButton;

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl);
            driver.Manage().Window.Maximize();
            _logger.Info($"We have navigated to page {baseUrl}");
            Assert.AreEqual("Welcome: Mercury Tours", driver.Title);
        }

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