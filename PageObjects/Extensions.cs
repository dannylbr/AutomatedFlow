﻿using OpenQA.Selenium;


namespace AutomatedFlow
{
    public static class Extensions
    {
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
