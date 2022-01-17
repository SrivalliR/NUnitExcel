using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace NUnitExcel
{
    class Program
    {
        private IWebDriver driver;

        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Setup()
        {
           driver = new ChromeDriver();
            //driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://wwww.google.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


        }
        [TearDown]
        public void Teardown()
        {
           driver.Close();   
        }

        [Test]
        public void ExecuteScript()
        {                   
            driver.FindElement(By.Id("q")).SendKeys("Specflow");

        }

    }
}
