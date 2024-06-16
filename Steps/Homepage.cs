using AutomatedFlow.Drivers;
using AutomatedFlow.Helpers;
using AutomatedFlow.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
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

        public Homepage(IDriverFixture driverFixture, HomePageObject home)
        {
            _driver = driverFixture.Driver;
            _home = home;
        }
        
        [Given(@"I navigate to Integræ Solutions homepage")]
        public void GivenINavigateToIntegraeSolutionsHomepage() => _driver.Navigate().GoToUrl("https://sites.google.com/view/integraesol/");

        [Then(@"Elegant text is shown")]
        public void ThenElegantTextIsShown() => Assert.True(_home.Act(Id.Elegant), "Elegant text is not shown");

        [When(@"Click on Projects link")]
        public void WhenClickOnProjectsLink() => Assert.True(_home.Act(Id.Projects), "Projects link could not be clicked");

        [Then(@"Projects page is shown")]
        public void ThenProjectsPageIsShown() => Assert.True(_home.Act(Id.Title), "The page does not have Projects title");

        [When(@"Click on About link")]
        public void WhenClickOnAboutLink() => Assert.True(_home.Act(Id.About), "About link could not be clicked");

        [Then(@"About page is shown")]
        public void ThenAboutPageIsShown() => Assert.True(_home.Act(Id.Title), "The page does not have About title");

        [When(@"Click on Comments link")]
        public void WhenClickOnCommentsLink() => Assert.True(_home.Act(Id.Comments), "Comments link could not be clicked");

        [Then(@"Comments page is shown")]
        public void ThenCommentsPageIsShown() => Assert.True(_home.Act(Id.Title), "The page does not have Comments title");

        [Then(@"I click in all the links and they succeed")]
        public void ThenIClickInAllTheLinksAndTheySucceed() => Assert.True(_home.Act(Id.FirstLink), "The page does not have the first link");
    }
}
