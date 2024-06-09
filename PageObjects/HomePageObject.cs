using AutomatedFlow.Drivers;
using AutomatedFlow.Helpers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomatedFlow.PageObjects
{
    [Binding]
    public sealed class HomePageObject : BasePageObject
    {
        public HomePageObject(IDriverFixture driverFixture) : base(driverFixture.Driver) { }

        public override Maybe<IWebElement> Get(Id id) => id switch
        {
            Id.Elegant => FindElementSafe(By.XPath("//*[@id=\"h.3a4bb1d2f4063c83_0\"]/div/div/p/span")),
            Id.Projects => FindElementSafe(By.XPath("//*[@id=\"WDxLfe\"]/ul/li[2]/div[1]/div/a")),
            Id.About => FindElementSafe(By.XPath("//*[@id=\"WDxLfe\"]/ul/li[3]/div[1]/div/a")),
            Id.Comments => FindElementSafe(By.XPath("//*[@id=\"WDxLfe\"]/ul/li[4]/div[1]/div/a")),
            Id.FirstLink => FindElementSafe(By.XPath("//p/a/span")),
            Id.Title => FindElementSafe(By.ClassName("CGqCRe")),
            _ => Maybe<IWebElement>.None()
        };

        public override Maybe<bool> PerformAction(IWebElement element, Id id) => id switch
        {
            Id.Elegant => element.Displayed.ToMaybe(),
            Id.Projects => element.ClickSafe(),
            Id.About => element.ClickSafe(),
            Id.Comments => element.ClickSafe(),
            Id.FirstLink => element.ClickSafe(),
            Id.Title => element.Displayed.ToMaybe(),
            _ => Maybe<bool>.None()
        };
    }
}
