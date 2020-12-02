using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class HomePage: DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.Id("signin_button"));
        IWebElement lnkAccountSummary => Driver.FindElement(By.Id("account_summary_tab"));

        public void ClickLogin() => lnkLogin.Click();
        public bool isAccountSummaryTabDisplayed() => lnkAccountSummary.Displayed;
    }
}
