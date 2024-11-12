using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using Tracker.Shared;

namespace Api.Services;
public class RepairJobsRepository(IConfiguration configuration) : IRepairJobsRepository
{
    private readonly string _connectionString = configuration.GetConnectionString("TrackerDb") ??
                                                throw new ArgumentNullException();

    public IEnumerable<RepairJob> GetAll()
    {
        var query = "SELECT * FROM RepairJobs";
        IEnumerable<RepairJob> jobs;

        try
        {
            using var connection = new SqlConnection(_connectionString);
            jobs = connection.Query<RepairJob>(query);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return jobs;
    }
}
