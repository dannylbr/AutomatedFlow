using AutomatedFlow.Drivers;
using AutomatedFlow.Support;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using SolidToken.SpecFlow.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedFlow
{
    public sealed class Startup
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateService()
        {
            var services = new ServiceCollection();
            services.AddSingleton(new Settings
            {                
                ApplicationUrl = new Uri("https://sites.google.com/view/integraesol/")
            });
            services.AddScoped<IDriverFixture, DriverFixture>();
            return services;
        }
    }
}
