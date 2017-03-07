using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalRailViewer.Model
{
    public interface ITrainServices
    {
        Journey[] origin { get; set; }
        Journey[] destination { get; set; }
        DateTime generatedAt { get; set; }
        string currentOrigins { get; set; }
        string currentDestinations { get; set; }
        string sta { get; set; }
        string eta { get; set; }
        string std { get; set; }
        string etd { get; set; }
        string platform { get; set; }
        string @operator {get; set;}
        string operatorCode { get; set; }
        bool isCircularRoute { get; set; }
        bool filterLocationCancelled { get; set; }
        int serviceType { get; set; }
        string serviceID { get; set; }
        string adhocAlerts { get; set; }

    }
}
