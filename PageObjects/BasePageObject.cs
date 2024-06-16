using AngleSharp.Dom;
using AutomatedFlow.Helpers;
using OpenQA.Selenium;
using System;

namespace AutomatedFlow.PageObjects
{
    public abstract class BasePageObject
    {
        protected readonly IWebDriver _driver;

        protected BasePageObject(IWebDriver driver) => _driver = driver;

        protected Maybe<IWebElement> FindElementSafe(By by)
        {
            try
            {
                return _driver.FindElement(by).ToMaybe();
            }
            catch (NoSuchElementException)
            {
                return Maybe<IWebElement>.None();
            }
        }

        public abstract Maybe<IWebElement> Get(Id id);

        public bool Act(Id id) => Get(id).Bind(element => Action(element, id)).GetValueOrDefault(false);

        public abstract Maybe<bool> Action(IWebElement element, Id id);
    }


}
