using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {    // <summary>
         // Calculates the final score for the Deliv-e-droid game based on deliveries and collisions.
         // </summary>
         // <param name="Collisions">The number of times the droid collided with obstacles.</param>
         // <param name="Deliveries">The number of packages successfully delivered.</param>
         // <returns>The final calculated score as an integer.</returns>
         // <example>
         // POST localhost:xx/api/q1/DelivDroid
         // Header: Content-Type: application/x-www-form-urlencoded
         // Form body: Collisions=2&Deliveries=5
         // Response: 730
         // </example>
        [HttpPost(template: "DelivDroid")]
        public int DelivDroid ([FromForm] int Collisions, [FromForm] int Deliveries)
        {
            int score = (Deliveries * 50) - (Collisions * 10);

            if (Deliveries > Collisions)
            {
                score += 500;
            }

            return score;
        }
    }
}
