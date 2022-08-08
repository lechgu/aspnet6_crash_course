using AspNet6CrashCourse.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNet6CrashCourse.Controllers;

[ApiController]
[Route("api")]
public class RestController : ControllerBase
{
    private readonly Base64Encoder encoder;

    public RestController(Base64Encoder encoder)
    {
        this.encoder = encoder;
    }

    [HttpGet("encode/{value}")]
    public ActionResult Encode(string value)
    {
        var encoded = encoder.Encode(value);
        return new OkObjectResult(encoded);
    }

    [HttpGet("decode/{value}")]
    public ActionResult Decode(string value)
    {
        var decoded = encoder.Decode(value);
        return new OkObjectResult(decoded);
    }
}