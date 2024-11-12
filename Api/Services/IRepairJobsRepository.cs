using Tracker.Shared;

namespace Api.Services;
public interface IRepairJobsRepository
{
    IEnumerable<RepairJob> GetAll();
}
