using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace JoesFunny.Tests
{
    public class PageTests
    {
        [SetUp]
        public void setUp() {
            IWebDriver driver = new ChromeDriver("C:\\Program Files\\Google\\Chrome");
            
            driver.Navigate().GoToUrl("https://localhost:5167");
        } 
        [Test]
        public void TestPage()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://localhost:5167");
            var nameFilter = driver.FindElement(By.XPath("/ html / body / div / main / form / p / input[1]"));
            nameFilter.Click();
            nameFilter.SendKeys("Lebron James");
            Console.WriteLine(nameFilter.Text);
            Assert.That(true);
        }
    }
}
