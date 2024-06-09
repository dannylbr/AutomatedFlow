using AutomatedFlow.Helpers;
using OpenQA.Selenium;
using System;

namespace AutomatedFlow.PageObjects
{
    public abstract class BasePageObject
    {
        protected readonly IWebDriver driver;

        protected BasePageObject(IWebDriver driver) => this.driver = driver ?? throw new ArgumentNullException(nameof(driver));

        protected Maybe<IWebElement> FindElementSafe(By by)
        {
            try
            {
                return driver.FindElement(by).ToMaybe();
            }
            catch (NoSuchElementException)
            {
                return Maybe<IWebElement>.None();
            }
        }

        public abstract Maybe<IWebElement> Get(Id id);

        public bool Act(Id id) => Get(id).Bind(element => element.PerformAction(id)).GetValueOrDefault(false);
    }
}
