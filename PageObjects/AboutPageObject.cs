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
    public sealed class AboutPageObject
    {
        private readonly IWebDriver driver;

        public AboutPageObject(IDriverFixture driverFixture)
        {
            driver = driverFixture.Driver;
        }

        private IWebElement aboutTitle => driver.FindElement(By.XPath("//*[@id=\"h.b1a6f5g30gav\"]/span/strong"));

        public bool TitleIsDisplayed() => aboutTitle.Displayed;
    }
}
