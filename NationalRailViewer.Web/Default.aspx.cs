using NationalRailViewer.Model;
using System;
using System.Configuration;
using System.Web.UI;

namespace NationalRailViewer.Web
{
    public partial class Default : System.Web.UI.Page
    {
        public string Station { get; set; }

        public DateTime GeneratedAt { get; private set; }

        public StationDataResponse DepartureData { get; private set; }

        public StationDataResponse ArrivalData { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                string serviceURL = ConfigurationManager.AppSettings["ServiceURL"].ToString();
                string pageRefreshFrequency = ConfigurationManager.AppSettings["PageRefreshFrequency"].ToString();

                Response.AppendHeader("Refresh", pageRefreshFrequency);

                Station = Page.RouteData.Values["station"] as string;

                DepartureData = DataRequester.GetStationData(serviceURL, Station, RequestDataTypeEnum.Departures);
                ArrivalData = DataRequester.GetStationData(serviceURL, Station, RequestDataTypeEnum.Arrivals);

                GeneratedAt = DateTime.Now;

                if (DepartureData.ResponseStatus == ResponseStatusTypeEnum.Error || ArrivalData.ResponseStatus == ResponseStatusTypeEnum.Error)
                {
                    pnlError.Visible = true;
                }
                else
                {
                    ucDepartures.LoadData(DepartureData.Data);
                    ucArrivals.LoadData(ArrivalData.Data);
                }                
            }
        }
    }
}