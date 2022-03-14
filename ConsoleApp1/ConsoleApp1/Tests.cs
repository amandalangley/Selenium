using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Startbrowser()
        {
            driver = new ChromeDriver();
           
        }

        [Test]
        public void StartTest()
        {
            driver.Url = "https://www.rexelusa.com/";
            string selector = " a[alt='Wire, Cable, & Cord'] div[class='v-card__text']";

            //IWebElement element = driver.FindElement(By.CssSelector("a[href = /s/electrical-power-distribution?cat=yrikh6]"));
            IWebElement element2 = driver.FindElement(By.CssSelector(selector));
            element2.Click();
            driver.Manage().Window.Size = new Size(1000, 650);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/main/div/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div")).Click();

            

            //driver.FindElement(By.CssSelector("div#v-card__text div[text=Wire, Cable, & Cord]"));
            //element.SendKeys("test@gmail.com");
            //driver.FindElement(By.CssSelector("#philadelphia-field-submit")).Submit();
        }

        [TearDown]
        public void Close()
        {
            //driver.Quit();
        }
    }
}
