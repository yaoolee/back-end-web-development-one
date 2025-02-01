using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {   // <summary>
        // Calculates the total cost of an order for SquashFellows plushies.
        // The plushies are available in two sizes: Small ($25.50 CAD) and Large ($40.50 CAD).
        // A 13% HST tax is applied to the total.
        // </summary>
        // <param name="small">Number of Small plushies ordered.</param>
        // <param name="large">Number of Large plushies ordered.</param>
        // <returns>
        // A formatted string having the breakdown of the order, 
        // including subtotal, tax, and total price.
        // </returns>
        // <example>
        // POST api/q8/squashfellows
        // Header: Content-Type: application/x-www-form-urlencoded
        // Form Body: Small=2&Large=1
        // Response:
        // "2 Small @ $25.50 = $51.00; 1 Large @ $40.50 = $40.50; 
        // Subtotal = $91.50; Tax = $11.90 HST; Total = $103.40"
        // </example>
        [HttpPost(template:"squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string squashfellows([FromForm] int small, [FromForm] int large)
        {
            double SmallPrice = 25.50;
            double LargePrice = 40.50;
            double HST = 0.13; 
            double smallTotal = small * SmallPrice;
            double largeTotal = large * LargePrice;
            double subtotal = smallTotal + largeTotal;
            double tax = subtotal * HST;
            double total = subtotal + tax;
            CultureInfo culture = new CultureInfo("en-CA");
            return $"{small} Small @ {SmallPrice.ToString("C2", culture)} = {smallTotal.ToString("C2", culture)}; " +
            $"{large} Large @ {LargePrice.ToString("C2", culture)} = {largeTotal.ToString("C2", culture)}; " +
            $"Subtotal = {subtotal.ToString("C2", culture)}; " +
                  $"Tax = {tax.ToString("C2", culture)} HST; " +
                  $"Total = {total.ToString("C2", culture)}";
        }
    }
}
