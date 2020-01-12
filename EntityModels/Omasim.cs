using System;
using System.Collections.Generic;

namespace RailTimesApi.Models
{
    public class Omasim
    {
        public int TrainNumber { get; set; }
        public List<Station> Stations { get; set; }
    }
}
