using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        // <summary>
        // Calculates the total Scoville Heat Units (SHU) based on the provided ingredients.
        // </summary>
        // <param name="ingredients">A list of pepper names.</param>
        // <returns>The total SHU value for the given peppers.</returns>
        // <example>
        // GET /api/q3/ChiliPeppers?Ingredients=Poblano,Cayenne,Thai,Poblano
        // Response: 118000
        // </example>
        private static readonly Dictionary<string, int> PepperSHU = new Dictionary<string, int>
    {
        { "Poblano", 1500 },
        { "Mirasol", 6000 },
        { "Serrano", 15500 },
        { "Cayenne", 40000 },
        { "Thai", 75000 },
        { "Habanero", 125000 }
    };
        [HttpGet(template:"ChiliPeppers")]
        public int ChiliPeppers([FromQuery] string Ingredients)
        {
           string[] peppers = Ingredients.Split(',');
            int totalSHU = 0;

            foreach (string pepper in peppers)
            {
                string trimmedPepper = pepper.Trim(); // Remove any spaces

                if (PepperSHU.ContainsKey(trimmedPepper)) // Check if pepper exists
                {
                    totalSHU += PepperSHU[trimmedPepper]; // Add SHU value
                }
            }

            return totalSHU;
        }





    }
}
