using Microsoft.AspNetCore.Mvc;

namespace SIHSALUS_DocumentGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "DemoPrevisualization")]
        public String Get()
        {

            
            return "";
        }
    }
}