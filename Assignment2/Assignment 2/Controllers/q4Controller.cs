using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {   // <summary>
        // Processes a sequence of Yobi sizes to determine the final size of Dusa before it runs away.
        // </summary>
        // <param name="dusaSize">The initial size of Dusa.</param>
        // <param name="yobiSizes">A string of Yobi sizes encountered in order.</param>
        // <returns>The final size of Dusa before it encounters a Yobi it cannot eat.</returns>
        // <example>
        // GET /api/q4/dusa?dusaSize=10&yobiSizes=5
        // Response: { "FinalDusaSize": 15 }
        // </example>
        [HttpGet(template:"Dusa")]
        public IActionResult Dusa([FromQuery] int dusaSize, [FromQuery] string yobiSizes)
        {
            int currentIndex = 0, yobi;
            string[] yobiArray = yobiSizes.Split(',');

            while (currentIndex < yobiArray.Length)
            {
                if (int.TryParse(yobiArray[currentIndex], out yobi))
                {
                    if (yobi < dusaSize)
                    {
                        dusaSize += yobi;
                    }
                    else
                    {
                        break; 
                    }
                }
                currentIndex++;
            }

            return Ok(new { FinalDusaSize = dusaSize });
        }
    }


   
}