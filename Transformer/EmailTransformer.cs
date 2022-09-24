using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomatedFlow.Transformer
{
    [Binding]
    class EmailTransformer
    {
        [StepArgumentTransformation(@"(.*) email")]
        public string GenerateDynamicEmailAddress(string emailAddress) => $"{emailAddress.Split("@")[0]}@{GetRandomDomain()}";
        private string GetRandomDomain() => new Fixture().Create<MailAddress>().Host;
    }
}
