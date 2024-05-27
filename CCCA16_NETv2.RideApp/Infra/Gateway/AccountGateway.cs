using CCCA16_NETv2.RideApp.Domain.Contracts;

namespace CCCA16_NETv2.RideApp.Infra.Gateway
{
    public class AccountGateway : IAccountGateway
    {
        private readonly IHttpClientFactory _clientFactory;

        public AccountGateway(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<AccountOutput> GetAccountById(Guid accountId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"Account?accountId={accountId}");
            var httpClient = _clientFactory.CreateClient("AccountGateway");
            var response = await httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode) return null;
            var account = await response.Content.ReadFromJsonAsync<AccountOutput>();
            return account;
        }

        public Guid Signup(SignUpInput input)
        {
            throw new NotImplementedException();
        }
    }
}
