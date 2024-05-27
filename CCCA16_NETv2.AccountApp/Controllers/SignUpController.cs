using CCCA16_NETv2.AccountApp.Application.UseCase;
using CCCA16_NETv2.AccountApp.Domain.Contract.Gateway;
using CCCA16_NETv2.AccountApp.Domain.Contract.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CCCA16_NETv2.AccountApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SignUpController : ControllerBase
    {
        private readonly ILogger<SignUpController> _logger;

        public SignUpController(ILogger<SignUpController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public async Task<Guid> Signup(SignUpInput input, IAccountRepository accountRepository, IMailerGateway mailerGateway)
        {
            var signUp = new SignUp(accountRepository, mailerGateway);
            return await signUp.Execute(input);
        }
    }
}
