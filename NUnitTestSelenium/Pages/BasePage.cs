using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using NLog;
using System.Configuration;
using NUnit.Framework;

namespace NUnitTestSelenium.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver { get; set; }
        String baseUrl = ConfigurationManager.AppSettings.Get("BaseURL");
        protected static Logger _logger = LogManager.GetCurrentClassLogger();
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        public void GoToHomePage()
        {
            Driver.Navigate().GoToUrl(baseUrl);
            Driver.Manage().Window.Maximize();
            _logger.Info($"We have navigated to page {baseUrl}");
            Assert.AreEqual("Welcome: Mercury Tours", Driver.Title);
        }
    }
}
