using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace NUnitTestSelenium
{
    public class Driver
    {
        public Driver()
        {
        }
        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver("/Users/robertgillespie/eclipse-workspace/");
            return driver;
        }

    }
}
