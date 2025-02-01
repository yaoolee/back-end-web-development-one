using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {   // <summary>
        // Receives HTTP GET request of value and provides the area of hexagon with side length double.
        // </summary>
        // <returns>The area of a regular hexagon with side length double {S} using math.sqrt math.pow</returns>
        // <example>
        // GET api/q6/hexagon?side=1 -> 2.598
        // </example>
        [HttpGet(template: "hexagon")]
        public double hexagon(double side)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
        }
    }
}
