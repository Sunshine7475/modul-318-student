using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace SwissTransport
{
    public class Connections
    {
        [JsonProperty("connections")]
        public List<Connection> ConnectionList { get; set; }
    }

    public class Connection
    {
        string _duration = "";


        [JsonProperty("from")]
        public ConnectionPoint From { get; set; }

        [JsonProperty("to")]
        public ConnectionPoint To { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; } 
        /*public string Duration
        {
            get
            {
                DateTime result;
                DateTime.TryParse(_duration, out result);
               return result.ToString("hh:mm:ss");
            }
            set
            {
                _duration = value;
            }

        }
        */

        public override string ToString()
        {
            return From.ToString();
        }
    }

    public class ConnectionPoint
    {
        [JsonProperty("station")]
        public Station Station { get; set; }

        public string Arrival { get; set; }

        public string ArrivalTimestamp { get; set; }

        public string Departure { get; set; }

        public string DepartureTimestamp { get; set; }

        public int? Delay { get; set; }

        public string Platform { get; set; }

        public string RealtimeAvailability { get; set; }

        public override string ToString()
        {
            return Station.ToString();
        }
    }
}