using Microsoft.AspNetCore.Mvc;

namespace AspNet6CrashCourse.Controllers;

[ApiController]
[Route("api")]
public class RestController : ControllerBase
{
    [HttpGet("encode")]
    public ActionResult Encode()
    {
        return new JsonResult("encoded string");
    }
}