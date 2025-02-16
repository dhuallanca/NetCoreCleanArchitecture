using Application.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace WebAPI.Controllers
{
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
        protected IActionResult HandleActionResult<T>(Result<T> result)
        {
            if(result.IsFailure)
            {
                var problemDetails = new ProblemDetails
                {
                    Title = "Error",
                    Status = result.Error?.StatusCode,
                    Detail = result.Error?.Message,
                    Instance = HttpContext.Request.Path
                };

                return Problem(
                    detail: problemDetails.Detail, title: problemDetails.Title, statusCode: problemDetails.Status, instance: problemDetails.Instance);
            }

            return Ok(result.Model);
        }
    }
}
