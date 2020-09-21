using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnitTestSelenium.Pages;
using NUnitTestSelenium.TestCases;

//To do:
//Add assertions (assert.true assert.isEqual ) and error handling (Try-Catch blocks)
//Add logging - log errors and steps - Done
//Add App.Config - done
//Add Reporting - test reporting in HTML
//Add data reader - store dynamic test data in excel, csv, json, xml, txt files


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
            Thread.Sleep(3000);
        }
        [Test]
        public void Test2()
        { 
            LoginTest.LoginTest1(driver);
            Thread.Sleep(3000);         
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}