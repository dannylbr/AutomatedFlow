using AutomatedFlow.Drivers;
using AutomatedFlow.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomatedFlow.Hooks
{
    [Binding]
    public sealed class TestInitialize
    {
        public TestInitialize()
        {

        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

        }

        [BeforeFeature]
        public static void BeforeFeature()
        {

        }


        [AfterScenario]
        public void KillDriver() 
        {

        }
    }
}
