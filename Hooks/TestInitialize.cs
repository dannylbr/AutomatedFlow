using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using Reqnroll;
using Reqnroll.BoDi;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomatedFlow.Hooks
{
    [Binding]
    public class TestInitialize(IObjectContainer objectContainer)
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            var options = new ChromeOptions();
            options.AddArguments("--test-type"
                , "--start-maximized"
                , "--no-sandbox"
                , "--ignore-certificate-errors"
                , "--headless");            
            var Actor = new Actor("AutomatedFlowActor", new ConsoleLogger());
            Actor.Can(BrowseTheWeb.With(new ChromeDriver(options)));
            objectContainer.RegisterInstanceAs(Actor);
        }

        [AfterScenario]
        public void AfterScenario() { try { objectContainer.Resolve<Actor>().AttemptsTo(QuitWebDriver.ForBrowser()); } catch { } }
    }
}
