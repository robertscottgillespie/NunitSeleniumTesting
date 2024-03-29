﻿using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;


namespace NUnitTestSelenium.Pages
{
    public class RegisterPage : BasePage
    {
        String expectedTitle = "Register: Mercury Tours";
        public RegisterPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.Name, Using = "firstName")]
        private IWebElement firstName;

        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement lastName;

        [FindsBy(How = How.Name, Using = "phone")]
        private IWebElement phoneNumber;

        [FindsBy(How = How.Name, Using = "userName")]
        private IWebElement userName;

        [FindsBy(How = How.Name, Using = "address1")]
        private IWebElement address1;

        [FindsBy(How = How.Name, Using = "city")]
        private IWebElement city;

        [FindsBy(How = How.Name, Using = "state")]
        private IWebElement state;

        [FindsBy(How = How.Name, Using = "postalCode")]
        private IWebElement postCode;

        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement email;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.Name, Using = "confirmPassword")]
        private IWebElement confirmPassword;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'REGISTER')]")]
        private IWebElement registerLink;

        [FindsBy(How = How.Name, Using = "submit")]
        private IWebElement submitButton;

        public void VerifyRegPage()
        {
            Assert.AreEqual(expectedTitle, Driver.Title);
        }


        public void GoToRegisterPage()
        {
            registerLink.Click();
        }

        public void TypeFirstName(string firstname)
        {
            firstName.SendKeys(firstname);
        }
        public void TypeLastName(string lastname)
        {
            lastName.SendKeys(lastname);
        }
        public void TypePhone(string phoneNum)
        {
            phoneNumber.SendKeys(phoneNum);
        }
        public void TypeUserName(string username)
        {
            userName.SendKeys(username);
        }
        public void TypeAddress(string address)
        {
            address1.SendKeys(address);
        }
        public void TypeCity(string city1)
        {
            city.SendKeys(city1);
        }
        public void TypeState(string state1)
        {
            state.SendKeys(state1);
        }
        public void TypePostCode(string postalCode)
        {
            postCode.SendKeys(postalCode);
        }
        public void TypeEmail(string userEmail)
        {
            email.SendKeys(userEmail);
        }

        public void TypePassword(string password1)
        {
            password.SendKeys(password1);
        }
        public void TypeConfirmPassword(string password1)
        {
            confirmPassword.SendKeys(password1);
        }

        public void ClickSubmitButton()
        {
            submitButton.Click();
        }



    }
}
