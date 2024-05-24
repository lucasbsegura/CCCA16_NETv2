using CCCA16_NETv2.AccountApp.Domain.Contract.Gateway;

namespace CCCA16_NETv2.AccountApp.Infra.Gateway
{
    public class MailerGateway : IMailerGateway
    {
        public void Send(string recipient, string subject, string content)
        {
            Console.WriteLine($"{recipient}, {subject}, {content}");
        }
    }
}
