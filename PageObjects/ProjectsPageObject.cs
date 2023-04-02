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
    public sealed class ProjectsPageObject
    {
        private readonly IWebDriver driver;
        public ProjectsPageObject(IDriverFixture driverFixture)
        {
            driver = driverFixture.Driver;
        }
        
        private IWebElement projectsTitle => 
            driver.FindElement(By.ClassName("CGqCRe"));

        public bool TitleIsDisplayed() => projectsTitle.Displayed;
    }
}
