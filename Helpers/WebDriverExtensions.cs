using OpenQA.Selenium;
using System.Collections.Generic;

namespace AutomatedFlow.Helpers
{
    public static class WebDriverExtensions
    {
        public static List<string>? GetPerformanceEntries(this IWebDriver driver)
               => ((IJavaScriptExecutor)driver).ExecuteScript("return window.performance.getEntries();") as List<string>;
    }
}
