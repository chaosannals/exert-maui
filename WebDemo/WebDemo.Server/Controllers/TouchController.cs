using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class TouchController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return Json(new
        {
            Code=0,
            Message="Ok",
        });
    }
}
