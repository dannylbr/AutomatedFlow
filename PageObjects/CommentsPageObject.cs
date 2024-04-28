using AutomatedFlow.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomatedFlow.PageObjects
{
    [Binding]
    public sealed class CommentsPageObject
    {
        private readonly IWebDriver driver;

        public CommentsPageObject(IDriverFixture driverFixture) => driver = driverFixture.Driver;
    }
}
