using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class ApplogHTTPTrigger
    {
        private readonly ILogger<ApplogHTTPTrigger> _logger;

        public ApplogHTTPTrigger(ILogger<ApplogHTTPTrigger> logger)
        {
            _logger = logger;
        }

        [Function("ApplogHTTPTrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP Luna trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
