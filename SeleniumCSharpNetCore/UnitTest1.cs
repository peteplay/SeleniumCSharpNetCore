using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;
using System;

namespace SeleniumCSharpNetCore
{
    // Tests inherits DriverHelper
    public class Tests : DriverHelper
    {
        //public IWebDriver Driver;
        
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            
            // Chapter 9 XPath element locator for Celery checkbox
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            //string comboxControlName = "ContentPlaceHolder1_AllMealsCombo";
            //IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));

            //comboControl.Clear();
            //comboControl.SendKeys("Almond");
            //Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();

            // instantiate the CustomControl class, then call its method with 2 parameters
            //CustomControl control = new CustomControl(); // not required after adding static
            //control.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            Console.WriteLine("Test1");
            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://zero.webappsecurity.com/index.html");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword("username", "password");
            loginPage.ClickSubmit();
            Assert.That(homePage.isAccountSummaryTabDisplayed, Is.True, "The Account Summary is not display");
        }
    }
}