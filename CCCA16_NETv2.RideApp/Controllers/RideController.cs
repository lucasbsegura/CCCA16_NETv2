using CCCA16_NETv2.RideApp.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CCCA16_NETv2.RideApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RideController : ControllerBase
    {
        private readonly ILogger<RideController> _logger;

        public RideController(ILogger<RideController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public async Task<AccountOutput> Get(Guid id, IAccountGateway accountGateway)
        {
            var account = await accountGateway.GetAccountById(id);
            _logger.LogInformation(account.ToString());
            return account;
        }

    }
}
