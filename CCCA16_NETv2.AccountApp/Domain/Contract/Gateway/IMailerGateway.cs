namespace CCCA16_NETv2.AccountApp.Domain.Contract.Gateway
{
    public interface IMailerGateway
    {
        void Send(string recipient, string subject, string content);
    }
}
