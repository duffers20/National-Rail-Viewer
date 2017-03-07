using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalRailViewer.Model
{
    public class Journey : IJourney
    {
        public Journey() { }
        public bool assocIsCancelled { get; set; }

        public string crs { get; set; }

        public string futureChangeTo { get; set; }

        public string locationName { get; set; }

        public string via { get; set; }
    }
}
