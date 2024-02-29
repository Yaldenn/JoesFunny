using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace JoesFunny.Tests
{
    public class PagePageObject
    {
        //IWebDriver driver = new EdgeDriver();
        public void ClickFilter(IWebDriver driver)
        {
            var filter = driver.FindElement(By.XPath("//input[@value='Filter']"));
            filter.Click();
        }
        public void EnterFilterText(IWebDriver driver) {
            var nameFilter = driver.FindElement(By.XPath("//input[@name='SearchString']"));
            nameFilter.Click();
            nameFilter.SendKeys("Lebron James");
        }
        
    }
}
