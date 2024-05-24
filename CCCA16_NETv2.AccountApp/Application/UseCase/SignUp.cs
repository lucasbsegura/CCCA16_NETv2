using CCCA16_NETv2.AccountApp.Domain.Contract.Gateway;
using CCCA16_NETv2.AccountApp.Domain.Contract.Repository;
using CCCA16_NETv2.AccountApp.Domain.Entity;

namespace CCCA16_NETv2.AccountApp.Application.UseCase
{
    public class SignUp(IAccountRepository accountRepository, IMailerGateway mailerGateway)
    {
        private readonly IAccountRepository _accountRepository = accountRepository;
        private readonly IMailerGateway _mailerGateway = mailerGateway;

        public async Task<Guid> Execute(SignUpInput input)
        {
            var existingAccount = await _accountRepository.GetAccountByEmail(input.Email);
            if (existingAccount != null) throw new Exception("Account already exists");
            var account = Account.Create(input.Name, input.Email, input.Cpf, input.CarPlate, input.IsPassenger, input.IsDriver);
            _accountRepository.SaveAccount(account);
            _mailerGateway.Send(account.Email.GetValue(), "Welcome!", "You are registered!");
            return account.AccountId;
        }
    }

    public class SignUpInput
    {
        public Guid AccountId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string CarPlate { get; set; }
        public bool IsPassenger { get; set; }
        public bool IsDriver { get; set; }
    }
}
