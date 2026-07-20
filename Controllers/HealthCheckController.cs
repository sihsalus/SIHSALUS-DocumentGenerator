using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SIHSALUS_DocumentGenerator.Controllers
{
    [ApiController]
    [Route("/")]
    [AllowAnonymous]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public ActionResult<object> Get()
        {
            return Ok(new { status = "ok" });
        }
    }
}
