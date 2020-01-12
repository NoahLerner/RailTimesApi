using System;
using System.Collections.Generic;

namespace RailTimesApi.Models
{
    public class ResponseObject
    {
        public int MessageType { get; set; }
        public object Message { get; set; }
        public Data Data { get; set; }
    }
}
