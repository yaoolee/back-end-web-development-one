using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {   // <summary>
        // Calculates and returns the distance table for five cities based on given distances.
        // </summary>
        // <param name="distances">A list of integers representing distances between consecutive cities.</param>
        // <returns>A 5x5 matrix as a formatted string representing the distance between any two cities.</returns>
        // <example>
        // GET /api/q5/calculate?distances=2,3,5,7
        // Response:
        // 0 2 5 10 17
        // 2 0 3 8 15
        // 5 3 0 5 12
        // 10 8 5 0 7
        // 17 15 12 7 0
        // </example>
        [HttpGet(template:"calculate")]
        public ContentResult CalculateDistance([FromQuery] string distances)
        {
            string[] distanceArray = distances.Split(',');

            int d1 = int.Parse(distanceArray[0]);
            int d2 = int.Parse(distanceArray[1]);
            int d3 = int.Parse(distanceArray[2]);
            int d4 = int.Parse(distanceArray[3]);

            int c1 = 0;
            int c2 = c1 + d1;
            int c3 = c2 + d2;
            int c4 = c3 + d3;
            int c5 = c4 + d4;

            StringBuilder result = new StringBuilder();
            result.AppendLine($"{c1} {c2} {c3} {c4} {c5}");
            result.AppendLine($"{c2} {c1} {c3 - c2} {c4 - c2} {c5 - c2}");
            result.AppendLine($"{c3} {c3 - c2} {c1} {c4 - c3} {c5 - c3}");
            result.AppendLine($"{c4} {c4 - c2} {c4 - c3} {c1} {c5 - c4}");
            result.AppendLine($"{c5} {c5 - c2} {c5 - c3} {c5 - c4} {c1}");

            return Content(result.ToString(), "text/plain");
        }
    }
}
