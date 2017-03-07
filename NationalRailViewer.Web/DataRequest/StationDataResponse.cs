using NationalRailViewer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NationalRailViewer.Web
{
    public class StationDataResponse
    {
        public ResponseStatusTypeEnum ResponseStatus { get; set; }
        public QueryResult Data { get; set; }
    }
}