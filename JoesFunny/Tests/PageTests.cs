using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace JoesFunny.Tests
{
    public class PageTests
    {
        [SetUp]
        public void setUp() {
            IWebDriver driver = new EdgeDriver();
            //IWebDriver driver = new ChromeDriver("C:\\Users\\Joeya\\.cache\\selenium\\chrome\\win64\\122.0.6261.94\\chrome.exe");

            driver.Navigate().GoToUrl("http://localhost:5167"); 
        }
        [Test]
        public void TestPage()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("http://localhost:5167");
            var nameFilter = driver.FindElement(By.XPath("/ html / body / div / main / form / p / input[1]"));
            nameFilter.Click();
            nameFilter.SendKeys("Lebron James");
            Console.WriteLine(nameFilter.Text);
            Assert.That(true);
        }
    }
}
