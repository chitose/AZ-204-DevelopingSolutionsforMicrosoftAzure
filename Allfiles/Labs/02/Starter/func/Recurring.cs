using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace func
{
    public class Recurring
    {
        [FunctionName("Recurring")]
        public void Run([TimerTrigger("*/30 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
