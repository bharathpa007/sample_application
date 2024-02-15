using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace sample_application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       
        [HttpGet]
        public string Get()
        {
            return "ok";
        }
    }
}
