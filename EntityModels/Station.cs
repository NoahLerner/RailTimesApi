using System;

namespace RailTimesApi.Models
{
    public class Station
    {
        public int StationNumber { get; set; }
        public double OmesPercent { get; set; }
        public string Shmurim { get; set; }
        public string Time { get; set; }
        public int Platform { get; set; }
    }
}
