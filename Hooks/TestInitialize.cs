using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Reqnroll;
using Reqnroll.BoDi;
using System;

namespace AutomatedFlow.Hooks
{
    [Binding]
    public class TestInitialize(IObjectContainer objectContainer)
    {
        [BeforeScenario]
        public void BeforeScenario() => objectContainer.RegisterInstanceAs<IWebDriver>(new ChromeDriver());
    }
}
