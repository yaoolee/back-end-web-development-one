using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        // <summary>
        // Calculates the number of leftover cupcakes after distributing one per student.
        // </summary>
        // <param name="regularBoxes">The number of regular boxes, each holding 8 cupcakes.</param>
        // <param name="smallBoxes">The number of small boxes, each holding 3 cupcakes.</param>
        // <returns>The number of leftover cupcakes after each student gets one.</returns>
        // <example>
        // POST /api/q2/Cupcakeparty
        // Header: Content-Type: application/x-www-form-urlencoded
        // Form body: regularBoxes=2&smallBoxes=5
        // Response: 3
        // </example>
        [HttpPost (template: "Cupcakeparty")]
        public int Cupcakeparty([FromForm] int regularBoxes, [FromForm] int smallBoxes)
        {
            int totalCupcakes = (regularBoxes * 8) + (smallBoxes * 3);
            int students = 28;
            int leftover = totalCupcakes - students;

            return leftover;
        }
    }
}
