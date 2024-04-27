using AutomatedFlow.Drivers;
using AutomatedFlow.Helpers;
using AutomatedFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;

namespace AutomatedFlow.Steps
{
    public static class StepsExtensions
    {

    }

    [Binding]
    public sealed class Homepage
    {
        private readonly IWebDriver _driver;
        private readonly HomePageObject _home;
        private readonly ProjectsPageObject _projects;
        private readonly AboutPageObject _about;
        private readonly CommentsPageObject _comments;

        public Homepage(IDriverFixture driverFixture
            , HomePageObject home
            , ProjectsPageObject projects
            , AboutPageObject about
            , CommentsPageObject comments)
        {
            _driver = driverFixture.Driver;
            _home = home;
            _projects = projects;
            _about = about;
            _comments = comments;
        }

        [Given(@"I navigate to Integræ Solutions homepage")]
        public void GivenINavigateToIntegraeSolutionsHomepage() => _driver.Navigate()
            .GoToUrl("https://sites.google.com/view/integraesol/");

        [Then(@"Elegant text is shown")]
        public void ThenElegantTextIsShown() => Assert.True(_home.Act(Id.Elegant), "Elegant text is not shown");

        [When(@"Click on Projects link")]
        public void WhenClickOnProjectsLink() => _home.Act(Id.Projects);

        [Then(@"Projects page is shown")]
        public void ThenProjectsPageIsShown() => Assert.True(_projects.TitleIsDisplayed(),
            "The page does not have Projects title");

        [When(@"Click on About link")]
        public void WhenClickOnAboutLink() => _home.Act(Id.About);

        [Then(@"About page is shown")]
        public void ThenAboutPageIsShown() => _about.TitleIsDisplayed();

        [When(@"Click on Comments link")]
        public void WhenClickOnCommentsLink() => _home.Act(Id.Comments);

        [Then(@"Comments page is shown")]
        public void ThenCommentsPageIsShown() => _comments.TitleIsDisplayed();

        [Then(@"I click in all the links and they succeed")]
        public void ThenIClickInAllTheLinksAndTheySucceed() =>_home.Act(Id.FirstLink);

    }
}
