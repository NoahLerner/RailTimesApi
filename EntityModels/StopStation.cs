using System;

namespace RailTimesApi.Models
{
    public class StopStation
{
    public string StationId { get; set; }
    public string ArrivalTime { get; set; }
    public string DepartureTime { get; set; }
    public string Platform { get; set; }
}
}
