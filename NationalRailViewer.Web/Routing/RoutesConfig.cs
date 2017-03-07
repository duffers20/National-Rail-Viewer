using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace NationalRailViewer.Web
{
    public static class RoutesConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            Route stationRoute = new Route("{station}", new StationRouteHandler("~/Default.aspx"));
            stationRoute.Defaults = new RouteValueDictionary() { { "station", "Aberdeen" } };
            routes.Add("station-route", stationRoute);
        }
    }
}