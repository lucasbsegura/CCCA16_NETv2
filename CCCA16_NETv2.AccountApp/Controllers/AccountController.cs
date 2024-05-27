using CCCA16_NETv2.AccountApp.Application.UseCase;
using CCCA16_NETv2.AccountApp.Domain.Contract.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CCCA16_NETv2.AccountApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public async Task<AccountOutput> Get(Guid accountId, IAccountRepository accountRepository)
        {
            var getAccount = new GetAccount(accountRepository);
            _logger.LogInformation($"Get Account: {accountId}");
            return await getAccount.Execute(accountId);
        }
    }
}
