using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {   // <summary>
        // Receives HTTP GET request of value as {days) and returns it to current date, YYYY-MM-DD
        // </summary>
        // <returns> A string of the current date (formatted yyyy-MM-dd), adjusted by days.</returns>
        // <example>
        // GET api/q7/timemachine?days=1 -> 2025/02/01 (if called on 31 january 2025)
        // </example>
        [HttpGet(template: "timemachine")]
        public string timemachine(int days)
        {
            return DateTime.Today.AddDays(days).ToString("yyyy-MM-dd");
        }
    }
}
