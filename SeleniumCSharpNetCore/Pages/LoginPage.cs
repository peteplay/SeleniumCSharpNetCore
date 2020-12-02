using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class LoginPage : DriverHelper
    {
        IWebElement txtLogin => Driver.FindElement(By.Id("user_login"));
        IWebElement txtPassword => Driver.FindElement(By.Id("user_password"));
        IWebElement btnSignIn => Driver.FindElement(By.XPath("//input[@type='submit']"));

        public void EnterUserNameAndPassword(string username, string password)
        {
            txtLogin.SendKeys(username);
            txtPassword.SendKeys(password);
        }

        public void ClickSubmit()
        {
            btnSignIn.Click();
        }


    }
}
