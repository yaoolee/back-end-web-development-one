using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {   // <summary>
        // Receives HTTP Get request and returns a message.
        // </summary>
        // <returns> Returns HTTP response with message </returns>
        // <example> GET api/q1/welcome -> Hello world
        // </example>
        [HttpGet(template: "welcome")]
        public string welcome()
        {
            return "Welcome to 5125!";
        }
    }

}
