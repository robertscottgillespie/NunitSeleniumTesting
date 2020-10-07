using System;
using OpenQA.Selenium;
using NUnitTestSelenium.Pages;
using NUnit.Framework;

namespace NUnitTestSelenium.TestCases
{
    public class RegisterUserTest : TestBase
    {
        public RegisterUserTest()
        {
        }
        public static void RegisterUserTest1(IWebDriver driver)
        {

            
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

         
            RegisterPage regPage = new RegisterPage(driver);
            regPage.GoToHomePage();
            regPage.GoToRegisterPage();
            //regPage.VerifyRegPage();
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
            //regPage2.VerifyUserRegistration();
        }
    }
}







            

