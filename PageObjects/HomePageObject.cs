using AutomatedFlow.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomatedFlow.PageObjects
{
    [Binding]
    public sealed class HomePageObject
    {
        private readonly IWebDriver driver;

        public HomePageObject(IDriverFixture driverFixture)
        {
            driver = driverFixture.Driver;
        }

        private IWebElement elegantText => driver.FindElement(By.XPath("//*[@id=\"h.3a4bb1d2f4063c83_0\"]/div/div/p/span"));
        private IWebElement projectsLink => driver.FindElement(By.XPath("//*[@id=\"WDxLfe\"]/ul/li[2]/div[1]/div/a"));
        private IWebElement aboutLink => driver.FindElement(By.XPath("//*[@id=\"WDxLfe\"]/ul/li[3]/div[1]/div/a"));
        private IWebElement commentsLink => driver.FindElement(By.XPath("//*[@id=\"WDxLfe\"]/ul/li[4]/div[1]/div/a"));
        private IWebElement donateLink => driver.FindElement(By.XPath("//*[@id=\"WDxLfe\"]/ul/li[5]/div[1]/div/a"));
        
        public bool ElegantTextIsDisplayed() => elegantText.Displayed;
        public void ClickOnProjects() => projectsLink.Click();
        public void ClickOnAbout() => aboutLink.Click();
        public void ClickOnComments() => commentsLink.Click();
        public void ClickOnDonate() => donateLink.Click();
    }
}
