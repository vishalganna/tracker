using System;

namespace Tracker.Shared;
public class RepairJob
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int Cost { get; set; }
    public int Received { get; set; }
    public DateTime Date { get; set; }
    public string CustomerName { get; set; }
    public string CustomerPhone { get; set; }
    public string Comments { get; set; }
}