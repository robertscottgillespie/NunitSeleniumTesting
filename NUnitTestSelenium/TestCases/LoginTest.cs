using System;
using OpenQA.Selenium;
using NUnitTestSelenium.Pages;
using System.Configuration;

namespace NUnitTestSelenium.TestCases
{
    public class LoginTest : TestBase
    {
        public LoginTest()
        {
        }
        public static void LoginTest1(IWebDriver driver)
        {

            //String expectedTitle = "";

            String username = ConfigurationManager.AppSettings.Get("Username");
            String passwd = ConfigurationManager.AppSettings.Get("Password");


            //Enter values into the registration fields on the register web page
            //We are using the registerpage class and declaring an object of this type
            //we are then using the methods of this object to use a 'sendkeys' and enter
            //data into the fields on the page.


            HomePage homePage = new HomePage(driver);

            homePage.GoToHomePage();
            homePage.TypeUserName(username);
            homePage.TypePassword(passwd);
            homePage.ClickSubmitButton();

            //Verify and assert that the login was succesfull
 
        }
    }
}

