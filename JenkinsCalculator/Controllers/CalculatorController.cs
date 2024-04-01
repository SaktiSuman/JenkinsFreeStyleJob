using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        [HttpGet("subtract")]
        public int Sub(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        [HttpGet("multiply")]
        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        [HttpGet("divide")]
        public IActionResult Divide(int num1, int num2)
        {
            if(num2 == 0)
            {
                return BadRequest("Cannot divide by 0.");
            }
            int result = num1 / num2;
            return Ok(result);
        }
    }
}
