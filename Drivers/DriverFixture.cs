using AutomatedFlow.Support;
using Microsoft.VisualBasic.FileIO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using System;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomatedFlow.Drivers
{
    public interface IDriverFixture : IDisposable
    {
        IWebDriver Driver { get; }
    }

    public sealed class DriverFixture : IDriverFixture
    {
        private readonly IWebDriver _webDriver;

        public DriverFixture()
        {
            _webDriver = GetWebDriver();
        }

        public IWebDriver Driver => _webDriver;
        private IWebDriver GetWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            var options = new ChromeOptions();
            options.AddArguments("--test-type"
                , "--start-maximized"
                , "--no-sandbox"
                , "--ignore-certificate-errors"); 
            return new ChromeDriver(options);
        }

        public IWebDriver Setup(string browserName)
        {
            dynamic capability = GetBrowserOptions(browserName);
            var driver = new RemoteWebDriver(new Uri(""), capability.ToCapabilities());
            return driver;
        }

        private dynamic GetBrowserOptions(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "chrome":
                    return new ChromeOptions();
                case "firefox":
                    return new FirefoxOptions();
                case "microsoftedge":
                    return new EdgeOptions();
                case "safari":
                    return new SafariOptions();
            }
            return new ChromeOptions();
        }

        public void Dispose()
        {
            if (Driver != null)
                Driver.Close();
        }
    }
}