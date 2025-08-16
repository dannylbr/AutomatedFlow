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
        public IWebDriver? WebDriver { get; private set; }
        [BeforeScenario]
        public void BeforeScenario()
        {
            var options = new ChromeOptions();
            try
            {
                WebDriver = new RemoteWebDriver(new Uri(""), options.ToCapabilities());
            }
            catch (Exception)
            {
                WebDriver = new ChromeDriver(options);
            }  
            objectContainer.RegisterInstanceAs(WebDriver);
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
