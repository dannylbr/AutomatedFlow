using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using Reqnroll.BoDi;
using System;

namespace AutomatedFlow.Hooks
{
    [Binding]
    public class TestInitialize(IObjectContainer objectContainer)
    {
        Actor? Actor { get; set; }
        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new();
            options.AddArgument("headless");
            options.AddArgument("window-size=1920,1080");
            var Actor = new Actor("AutomatedFlowActor", new ConsoleLogger());
            Actor.Can(BrowseTheWeb.With(new ChromeDriver(options)));
            objectContainer.RegisterInstanceAs(Actor);
        }

        [AfterScenario]
        public void AfterScenario() => Actor?.AttemptsTo(QuitWebDriver.ForBrowser());
    }
}
