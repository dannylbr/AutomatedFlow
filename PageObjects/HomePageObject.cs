using AutomatedFlow.Helpers;
using OpenQA.Selenium;

namespace AutomatedFlow.PageObjects
{
    public sealed class HomePageObject(IWebDriver driver) : BasePageObject(driver)
    {

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

        public override Maybe<bool> Action(IWebElement element, Id id) => id switch
        {
            Id.Elegant => element.Displayed.ToMaybe(),
            Id.Projects => element.ClickSafe(),
            Id.About => element.ClickSafe(),
            Id.Comments => element.ClickSafe(),
            Id.FirstLink => element.ClickSafe(),
            Id.Title => element.Displayed.ToMaybe(),
            _ => Maybe<bool>.None()
        };

        public bool ElegantTextIsShown() => Act(Id.Elegant);
    }
}
