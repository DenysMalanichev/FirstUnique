using Microsoft.AspNetCore.Mvc;

namespace FirstUnique.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FirstUniqueController : Controller
{
    [HttpGet]
    public IActionResult GetFirstUnique(string text)
    {
        if(string.IsNullOrEmpty(text))
        {
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        return Ok(UniqueFinder.Find(text));
    }
}