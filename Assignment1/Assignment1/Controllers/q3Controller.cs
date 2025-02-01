using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {   // <summary>
        // Receives HTTP Get request with one integer as number parameter and provides a message
        // </summary>
        // <returns> Returns HTTP response with value of number parameter </returns>
        // <example> GET api/cube/4 -> 64 (cube root of 4)
        // </example>
        [HttpGet(template: "cube/{number:int}")]
        public int cube(int number)
        {
            return number * number * number;       // 8 = 2 * 2 *2
        }
    }
}
