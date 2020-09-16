using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnitTestSelenium.Pages;
using NUnitTestSelenium.TestCases;

//To do:
//Add assertions and error handling
//Add logging - log errors and steps
//Add Reporting - test reporting in HTML
//Add data reader - store config in xml file, data in csv or excel


namespace NUnitTestSelenium
{
    public class TestSuite
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = Driver.InitializeDriver();
        }

        [Test]
        public void Test1()
        {

            RegisterUserTest.RegisterUserTest1(driver);
            
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}