using System;
using System.Collections.Generic;

namespace RailTimesApi.Models
{
    public class Route
    {
        public List<Train> Train { get; set; }
        public bool IsExchange { get; set; }
        public string EstTime { get; set; }
    }
}
