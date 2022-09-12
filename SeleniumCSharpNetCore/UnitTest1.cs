using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
        
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver("C:\\driver");

        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            Driver.FindElement(By.CssSelector("#maincont > div:nth-child(3) > div:nth-child(5) > div:nth-child(2) > div.awe-ajaxcheckboxlist-field.awe-field > div > ul > li:nth-child(1) > label > div.o-chk > div > div")).Click();

            CustomControl control = new CustomControl();
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");


           


            Console.WriteLine("Test 1");
            Assert.Pass();
        }
    }
}