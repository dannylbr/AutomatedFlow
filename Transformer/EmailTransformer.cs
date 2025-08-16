using AutoFixture;
using Reqnroll;
using System.Net.Mail;

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
