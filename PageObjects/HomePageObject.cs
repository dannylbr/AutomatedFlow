using AutomatedFlow.Drivers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomatedFlow.PageObjects
{
    [Binding]
    public sealed class HomePageObject
    {
        private readonly IWebDriver driver;

        public HomePageObject(IDriverFixture driverFixture) => driver = driverFixture.Driver;

        public IWebElement Get(Id id) => id switch
        {
            Id.Elegant => driver.GetByXpath("//*[@id=\"h.3a4bb1d2f4063c83_0\"]/div/div/p/span"),
            Id.Projects => driver.GetByXpath("//*[@id=\"WDxLfe\"]/ul/li[2]/div[1]/div/a"),
            Id.About => driver.GetByXpath("//*[@id=\"WDxLfe\"]/ul/li[3]/div[1]/div/a"),
            Id.Comments => driver.GetByXpath("//*[@id=\"WDxLfe\"]/ul/li[4]/div[1]/div/a"),
            Id.FirstLink => driver.GetByXpath("//p/a/span"),
            Id.Title => driver.GetByClass("CGqCRe"),
            _ => throw new NotImplementedException()
        };

        public bool Act(Id id) => id switch
        {
            Id.Elegant => Get(Id.Elegant).Displayed,
            Id.Projects => Get(Id.Projects).HasClicked(),
            Id.About => Get(Id.About).HasClicked(),
            Id.Comments => Get(Id.Comments).HasClicked(),
            Id.FirstLink => Get(Id.FirstLink).HasClicked(),
            Id.Title => Get(Id.Title).Displayed,
            _ => throw new NotImplementedException()
        };
    }
}
