using OpenQA.Selenium.Chrome;
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
        [Test]
        public void TestPage()
        {
            var nameFilter = driver.FindElement(By.XPath("/ html / body / div / main / form / p / input[1]"));
            nameFilter.Click();
            nameFilter.SendKeys("Lebron James");
            Console.WriteLine(nameFilter.Text);
            Assert.That(true);
        }
    }
}