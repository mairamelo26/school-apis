using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [Route("version"), ApiController]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public string Get() => "full";

    }
}
