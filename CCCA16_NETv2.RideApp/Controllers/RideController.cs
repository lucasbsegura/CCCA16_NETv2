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

    }
}
