using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Versionamento.API.Controllers.v1
{
    [ApiVersion(1.0)]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("User V1");
        }
    }
}
