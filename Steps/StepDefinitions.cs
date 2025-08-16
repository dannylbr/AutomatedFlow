using AutomatedFlow.PageObjects;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using Reqnroll;
using Xunit;

namespace AutomatedFlow.Steps
{
    [Binding]
    public sealed class StepDefinitions(Actor Actor)
    {
        [Given(@"I navigate to Integræ Solutions homepage")]
        public void GivenINavigateToIntegraeSolutionsHomepage() => Actor.AttemptsTo(Navigate.ToUrl(Home.Url));

        [Then(@"Elegant text is shown")]
        public void ThenElegantTextIsShown() => Assert.True(Actor.AskingFor(Existence.Of(Home.Elegant)), "Elegant text is not shown");

        [When(@"Click on Projects link")]
        public void WhenClickOnProjectsLink() => Actor.AttemptsTo(Click.On(Home.Projects));

        [Then(@"Projects page is shown")]
        [Then(@"About page is shown")]
        [Then(@"Comments page is shown")]
        public void ThenProjectsPageIsShown() => Assert.True(Actor.AskingFor<bool>(Existence.Of(Home.Title)), "Page title is not shown");

        [When(@"Click on About link")]
        public void WhenClickOnAboutLink() => Actor.AttemptsTo(Click.On(Home.About));

        [When(@"Click on Comments link")]
        public void WhenClickOnCommentsLink() => Actor.AttemptsTo(Click.On(Home.Comments));

        [Then(@"I click in all the links and they succeed")]
        public void ThenIClickInAllTheLinksAndTheySucceed() => Actor.AttemptsTo(Click.On(Home.FirstLink));
    }
}
