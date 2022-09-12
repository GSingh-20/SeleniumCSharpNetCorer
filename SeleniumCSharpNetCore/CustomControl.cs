using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCore
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']")); // can also use VAR type instead of IWebElement 
            comboControl.Clear();
            comboControl.SendKeys(value);
            Driver.FindElement(By.XPath($"//div[@id=\'{controlName}-dropmenu']//li[text()='{value}']")).Click(); //string interpolation is used to swap the id to ControlName and the value is Almond
        }

    }
}
