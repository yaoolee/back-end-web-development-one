using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {     // <summary>
          // Receives an HTTP POST request with an empty header body and provides a response message.
          // </summary>
          // <returns> HTTP response indicating the usage.</returns>
          // <example>
          // POST api/q4/knockknock
          // FORM DATA: (empty)
          // -> Received a POST request with no header and body
          // </example>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "whos there?";
        }
    }
}
