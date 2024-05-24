using CCCA16_NETv2.AccountApp.Domain.Entity;

namespace CCCA16_NETv2.AccountApp.Domain.Contract.Repository
{
    public interface IAccountRepository
    {
        Task<Account> GetAccountByEmail(string email);
        Task<Account> GetAccountById(Guid id);
        void SaveAccount(Account account);
    }
}
