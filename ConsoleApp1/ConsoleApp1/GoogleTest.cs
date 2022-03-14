using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GoogleTest
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void OpenBrowser()
        {
            driver.Url = "http://the-internet.herokuapp.com/";
        }

        [Test]
        public void FindByTextTest()
        {
            driver.FindElement(By.XPath("//h2[contains(text(),'Available Examples')]"));

        }
        [Test]
        public void WebsiteStart()
        {
            Assert.AreEqual(driver.Title, "The Internet");
            IWebElement link = driver.FindElement(By.LinkText("Add/Remove Elements"));
            link.Click();
            // add four elements
            for (int i=0; i<4; i++)
            {
                driver.FindElement(By.CssSelector(".example button[onclick= 'addElement()']")).Click();
            }

            // Find all elements and click them
            IList<IWebElement> elements = driver.FindElements(By.CssSelector("#elements .added-manually"));
            foreach (var element in elements)
            {
                element.Click();
            }
        }

        [Test]
        public void BasicAuthTest()
        {
            driver.Url = "http://admin:admin@the-internet.herokuapp.com/basic_auth";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(2));
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("example")));
        }

        [TearDown]
        public void CloseBrowser()
        {

        }
    }
}
