using AutomatedFlow.Drivers;
using AutomatedFlow.Helpers;
using AutomatedFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;

namespace AutomatedFlow.Steps
{
    [Binding]
    public sealed class Homepage
    {
        private readonly IWebDriver _driver;
        private readonly HomePageObject _home;
        private readonly ProjectsPageObject _projects;
        private readonly AboutPageObject _about;
        private readonly CommentsPageObject _comments;
        private readonly DonatePageObject _donate;

        public Homepage(IDriverFixture driverFixture
            , HomePageObject home
            , ProjectsPageObject projects
            , AboutPageObject about
            , CommentsPageObject comments
            , DonatePageObject donate)
        {
            _driver = driverFixture.Driver;
            _home = home;
            _projects = projects;
            _about = about;
            _comments = comments;
            _donate = donate;
        }

        [Given(@"I navigate to Integræ Solutions homepage")]
        public void GivenINavigateToIntegraeSolutionsHomepage()
        {
            _driver.Navigate().GoToUrl("https://sites.google.com/view/integraesol/");
            try
            {
                var perf = _driver.GetPerformanceEntries();
                if (null != perf && perf.Any())
                {
                    perf.ForEach(x => Console.WriteLine(x));
                }
            }
            catch
            {
                // no action
            } 
        }

        [Then(@"Elegant text is shown")]
        public void ThenElegantTextIsShown()
        {
            Assert.True(_home.ElegantTextIsDisplayed(), "Elegant text is not shown");
        }

        [When(@"Click on Projects link")]
        public void WhenClickOnProjectsLink()
        {
            _home.ClickOnProjects();
        }

        [Then(@"Projects page is shown")]
        public void ThenProjectsPageIsShown()
        {
            _projects.TitleIsDisplayed();
        }

        [When(@"Click on About link")]
        public void WhenClickOnAboutLink()
        {
            _home.ClickOnAbout();
        }

        [Then(@"About page is shown")]
        public void ThenAboutPageIsShown()
        {
            _about.TitleIsDisplayed();
        }

        [When(@"Click on Comments link")]
        public void WhenClickOnCommentsLink()
        {
            _home.ClickOnComments();
        }

        [Then(@"Comments page is shown")]
        public void ThenCommentsPageIsShown()
        {
            _comments.TitleIsDisplayed();
        }

        [When(@"Click on Donate link")]
        public void WhenClickOnDonateLink()
        {
            _home.ClickOnDonate();
        }

        [Then(@"Donate page is shown")]
        public void ThenDonatePageIsShown()
        {
            _donate.TitleIsDisplayed();
        }
    }
}
