
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetData()
        {
            string result = string.Empty;
            if(result.Length > 0) // will throw NullReferenceException
            {
                return Ok(new { message = "Data fetched" });
            }
            return BadRequest("No data");
        }
    }
}
