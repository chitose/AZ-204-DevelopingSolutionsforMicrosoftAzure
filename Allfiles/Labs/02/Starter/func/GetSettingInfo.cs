using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;

namespace func
{
    public static class GetSettingInfo
    {
        [FunctionName("GetSettingInfo")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req,
            [Blob("content/settings.json")] string json)
        {

            return new OkObjectResult(json);
        }
    }
}
