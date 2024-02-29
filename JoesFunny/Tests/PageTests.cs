using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace JoesFunny.Tests
{
    public class PageTests
    {
        IWebDriver driver = new EdgeDriver();
        [SetUp]
        public void setUp() {

            driver.Navigate().GoToUrl("http://localhost:5167"); 
        }

        [TearDown]
        public void tearDown()
        {
            driver.Dispose();
        }
        [Test]
        public void TestPage()
        {
            PagePageObject PO = new PagePageObject();
            PO.EnterFilterText(driver);
            PO.ClickFilter(driver);
            Assert.That(true);
        }
    }
}