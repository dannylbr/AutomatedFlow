using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace AutomatedFlow.PageObjects
{
    public static class Home
    {
        public const string Url = "https://sites.google.com/view/integraesol/";        
        public static WebLocator Elegant => L("Elegant", By.XPath("//*[@id=\"h.3a4bb1d2f4063c83_0\"]/div/div/p/span"));
        public static WebLocator Projects => L("", By.XPath("//*[@id=\"WDxLfe\"]/ul/li[2]/div[1]/div/a"));
        public static WebLocator About => L("", By.XPath("//*[@id=\"WDxLfe\"]/ul/li[3]/div[1]/div/a"));
        public static WebLocator Comments => L("", By.XPath("//*[@id=\"WDxLfe\"]/ul/li[4]/div[1]/div/a"));
        public static WebLocator FirstLink => L("", By.XPath("//p/a/span"));
        public static WebLocator Title => L("", By.ClassName("CGqCRe"));
    }
}
