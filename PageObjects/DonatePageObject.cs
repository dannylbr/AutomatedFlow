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
    public sealed class DonatePageObject
    {
        private readonly IWebDriver driver;

        public DonatePageObject(IDriverFixture driverFixture)
        {
            driver = driverFixture.Driver;
        }

        private IWebElement donateTitle => driver.FindElement(By.XPath("//*[@id=\"h.lm14pshe16uh\"]/span/strong"));

        public bool TitleIsDisplayed() => donateTitle.Displayed;
    }
}
