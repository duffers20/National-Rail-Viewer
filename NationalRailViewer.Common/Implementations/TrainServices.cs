using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalRailViewer.Model
{
    public class TrainServices : ITrainServices
    {
        public string adhocAlerts { get; set; }

        public string currentDestinations { get; set; }

        public string currentOrigins { get; set; }

        public DateTime generatedAt { get; set; }

        public Journey[] destination { get; set; }

        public string eta { get; set; }

        public string etd { get; set; }

        public bool filterLocationCancelled { get; set; }

        public bool isCircularRoute { get; set; }

        [JsonProperty("operator")]
        public string @operator { get; set; }

        public string operatorCode { get; set; }

        public Journey[] origin { get; set; }

        public string platform { get; set; }

        public string serviceID { get; set; }

        public int serviceType { get; set; }

        public string sta { get; set; }

        public string std { get; set; }
    }
}
