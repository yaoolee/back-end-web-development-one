using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {   // <summary>
        // Receives HTTP POST request with a body and provides a response.
        // </summary>
        // <returns> HTTP response displaying the request body using one parameter</returns>
        // <example>
        // POST api/q5/secret
        // HEADERS: Content-Type: application/json
        // FORM DATA: "{secret}"
        // -> A post method with a request body and header.
        // </example>
        [HttpPost(template: "secret")]
        public string secret([FromBody] int secret)
        {
            return $"SHH..the secret is {secret}";
        }
    }
}
