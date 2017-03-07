using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NationalRailViewer.Web
{
    public enum RequestDataTypeEnum
    {
        Departures,
        Arrivals
    }

    public enum ResponseStatusTypeEnum
    {
        Success,
        NoData,
        Error
    }
}