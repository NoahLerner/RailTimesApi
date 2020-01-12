using System;
using System.Collections.Generic;

namespace RailTimesApi.Models
{
    public class Data
    {
        public object Error { get; set; }
        public Details Details { get; set; }
        public int StartIndex { get; set; }
        public List<Route> Routes { get; set; }
        public object BeforeRoutes { get; set; }
        public List<object> Rates { get; set; }
        public List<object> Delays { get; set; }
        public List<object> TrainPositions { get; set; }
        public List<Omasim> Omasim { get; set; }
    }
}
