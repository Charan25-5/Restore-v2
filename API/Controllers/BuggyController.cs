using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController : BaseApiController
{
    [HttpGet("not-found")]
    public IActionResult GetNotFound()
    {
        return NotFound();
    }

    [HttpGet("bad-request")]
    public IActionResult GetBadRequest()
    {
        return BadRequest("This is not a Good Request");
    }

    [HttpGet("unauthorized")]
    public IActionResult GetUnauthorized()
    {
        return Unauthorized();
    }

    [HttpGet("validation-error")]
    public IActionResult GetValidationError()
    {
        ModelState.AddModelError("Problem","This is the first error");
        ModelState.AddModelError("Problem","This is the second error");
        return ValidationProblem();
    }
    
    [HttpGet("server-error")]
    public IActionResult GetServerError()
    {
        return StatusCode(500, new {
            title = "Server Error",
            status = 500,
            detail = "This is a server error"
        });

    }
    
}
