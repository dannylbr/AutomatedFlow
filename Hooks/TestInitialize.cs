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
        public ChromeDriver? WebDriver { get; private set; }
        [BeforeScenario]
        public void BeforeScenario()
        {
            var options = new ChromeOptions();
            options.AddArgument("--user-data-dir=/tmp/chrome-profile-" + Guid.NewGuid());
            WebDriver = new ChromeDriver(options);
            objectContainer.RegisterInstanceAs<IWebDriver>(WebDriver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (WebDriver != null)
            {
                WebDriver.Quit();
            }
        }
    }
}
