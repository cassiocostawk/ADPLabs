using ADP.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ADP.Api.Controllers
{
    [ApiController]
    [Route("api/task")]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Process()
        {
            var service = new TaskServices();

            var task = await service.GetTask();
            var dto = CalculateService.Calculate(task);            

            var result = await service.PostTask(dto);

            return result.StatusCode switch
            {
                HttpStatusCode.OK => Ok(result.Message),
                HttpStatusCode.BadRequest => BadRequest(result.Message),
                HttpStatusCode.NotFound => NotFound(result.Message),
                HttpStatusCode.ServiceUnavailable => StatusCode(StatusCodes.Status503ServiceUnavailable, result.Message),
                _ => NotFound(result.Message),
            };
        }
    }
}
