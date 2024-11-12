using Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Api.Functions
{
    public class GetRepairJobs(ILogger<GetRepairJobs> logger, IRepairJobsRepository repairJobsRepository)
    {
        [Function("GetRepairJobs")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "repairjobs")] HttpRequest req)
        {
            var jobs = repairJobsRepository.GetAll();

            return new OkObjectResult(jobs);
        }
    }
}
