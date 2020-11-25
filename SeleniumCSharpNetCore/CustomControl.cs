using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore
{
    // set class as public so it is accessible, and make it inherit the DriverHelper
    public class CustomControl: DriverHelper
    {
        // Add a method for the comboBox control written in the UnitTest1.cs
        // Select the combobox, clear it and type in a value

        public static void ComboBox(string controlName, string value)
        {
            // replace the following line with a string intropelation
            // IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));

            comboControl.Clear();
            // replace almond dynamically
            // comboControl.SendKeys("Almond");
            comboControl.SendKeys(value);

            // perform another string intropelation with the following line
            // Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }

    }
}
