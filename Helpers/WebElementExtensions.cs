using AutomatedFlow.Helpers;
using OpenQA.Selenium;
using System;

namespace AutomatedFlow.Helpers
{
    public static class WebElementExtensions
    {
        public static Maybe<IWebElement> ToMaybe(this IWebElement element) => element != null ? Maybe<IWebElement>.Some(element) : Maybe<IWebElement>.None();

        public static Maybe<bool> PerformAction(this IWebElement element, Id id) => id switch
        {
            Id.Elegant => element.Displayed.ToMaybe(),
            Id.Projects => element.ClickSafe(),
            Id.About => element.ClickSafe(),
            Id.Comments => element.ClickSafe(),
            Id.FirstLink => element.ClickSafe(),
            Id.Title => element.Displayed.ToMaybe(),
            _ => Maybe<bool>.None()
        };

        public static Maybe<bool> ClickSafe(this IWebElement element)
        {
            try
            {
                element.Click();
                return true.ToMaybe();
            }
            catch (Exception)
            {
                return Maybe<bool>.None();
            }
        }

        /// <summary>
        /// Get the element by xpath string
        /// </summary>
        /// <param name="driver">Selenium Webdriver</param>
        /// <param name="id">Xpath address</param>
        /// <returns></returns>
        public static IWebElement GetByXpath(this IWebDriver driver, string id) => driver.FindElement(By.XPath(id));
        public static IWebElement GetByClass(this IWebDriver driver, string id) => driver.FindElement(By.ClassName(id));
        public static bool HasClicked(this IWebElement element)
        {
            try
            {
                element.Click();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}