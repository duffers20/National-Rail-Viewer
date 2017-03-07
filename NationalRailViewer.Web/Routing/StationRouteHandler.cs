using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.Routing;
using System.Web.UI;

namespace NationalRailViewer.Web
{
    public class StationRouteHandler : IRouteHandler
    {
        public StationRouteHandler(string virtualPath)
        {
            this.VirtualPath = virtualPath;
        }

        public string VirtualPath { get; private set; }

        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return BuildManager.CreateInstanceFromVirtualPath(this.VirtualPath, typeof(Page)) as IHttpHandler;
        }
    }
}