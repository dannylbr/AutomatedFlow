using AutomatedFlow.Drivers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomatedFlow.PageObjects
{
    [Binding]
    public sealed class ProjectsPageObject
    {
        private readonly IWebDriver driver;
        public ProjectsPageObject(IDriverFixture driverFixture) => driver = driverFixture.Driver;      
    }
}
