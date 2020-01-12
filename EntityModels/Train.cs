using System;
using System.Collections.Generic;

namespace RailTimesApi.Models
{
    public class Train
{
    public string Trainno { get; set; }
    public string OrignStation { get; set; }
    public string DestinationStation { get; set; }
    public string ArrivalTime { get; set; }
    public string DepartureTime { get; set; }
    public List<StopStation> StopStations { get; set; }
    public string LineNumber { get; set; }
    public string Route { get; set; }
    public bool Midnight { get; set; }
    public bool Handicap { get; set; }
    public bool DirectTrain { get; set; }
    public object TrainParvariBenironi { get; set; }
    public bool ReservedSeat { get; set; }
    public string Platform { get; set; }
    public string DestPlatform { get; set; }
    public bool IsFullTrain { get; set; }
}
}
