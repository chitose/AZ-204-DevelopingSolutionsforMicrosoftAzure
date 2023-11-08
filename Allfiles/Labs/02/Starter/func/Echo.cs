using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace func
{
    public static class Echo
    {
        [FunctionName("Echo")]
        public static IActionResult  Run(
            [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Received a request");
            return new OkObjectResult(req.Body);
        }
    }
}
