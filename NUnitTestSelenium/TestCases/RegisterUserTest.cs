using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;
using NUnitTestSelenium.Pages;

namespace NUnitTestSelenium.TestCases
{
    public class RegisterUserTest
    {
        public RegisterUserTest()
        {
        }
        public static void RegisterUserTest1(IWebDriver driver)
        {

            //String expectedTitle = "Register: Mercury Tours";
            String firstName = "Rob";
            String lastName = "Gill";
            String phoneNum = "05789594586";
            String username = "BillC";
            String address = "marrow street";
            String city = "perth";
            String state = "uk";
            String postCode = "EH5 4TN";
            String email = "robscott@gmail.com";
            String passwd = "password1";


            //Enter values into the registration fields on the register web page
            //We are using the registerpage class and declaring an object of this type
            //we are then using the methods of this object to use a 'sendkeys' and enter
            //data into the fields on the page.

            //var driver = Driver.InitializeDriver();
            RegisterPage regPage = new RegisterPage(driver);
            regPage.GoToHomePage();
            regPage.GoToRegisterPage();
            regPage.TypeFirstName(firstName);
            regPage.TypeLastName(lastName);
            regPage.TypePhone(phoneNum);
            regPage.TypeUserName(username);
            regPage.TypeAddress(address);
            regPage.TypeCity(city);
            regPage.TypeState(state);
            regPage.TypePostCode(postCode);
            regPage.TypeEmail(email);
            regPage.TypePassword(passwd);
            regPage.TypeConfirmPassword(passwd);
            regPage.ClickSubmitButton();

            //verify and assert that the register new user was succesfull
        }
    }
}
/*






            /*
            String actualTitle = driver.Title;

            if (actualTitle.Equals(expectedTitle))
            {
                Console.WriteLine("Test Passed!");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            
            Thread.Sleep(2000);
            driver.FindElement(By.Name("submit")).Click();

            String successText = driver.FindElement(By.XPath("//font[contains(text(),'Thank you for registering.')]")).Text;
            Console.WriteLine(successText);
            if (successText.Contains("Thank you for registering"))
            {
                Console.WriteLine("Register user passed!");
            }
            else
            {
                Console.WriteLine("Register user failed");
            }
            */


