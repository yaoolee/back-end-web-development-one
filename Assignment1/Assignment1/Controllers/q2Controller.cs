using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {   // <summary>
        // Receives HTTP Get request with one parameter and returns a greeting.
        // </summary>
        // <returns> Returns HTTP response using provided parameter </returns>
        // <example> GET api/q2/greeting?name=sean -> Hi sean
        // </example>
        [HttpGet(template:"greeting")]
        public string greeting(string name)    // Here name is parameter
        {
            return $"Hi {name} !";
        }
    }
}
