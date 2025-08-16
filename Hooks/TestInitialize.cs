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
        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new();
            //options.AddArgument("--headless");
            var Actor = new Actor("AutomatedFlowActor", new ConsoleLogger());
            Actor.Can(BrowseTheWeb.With(new ChromeDriver(options)));
            objectContainer.RegisterInstanceAs(Actor);
        }

        [AfterScenario]
        public void AfterScenario() { try { objectContainer.Resolve<Actor>().AttemptsTo(QuitWebDriver.ForBrowser()); } catch { } }
    }
}
