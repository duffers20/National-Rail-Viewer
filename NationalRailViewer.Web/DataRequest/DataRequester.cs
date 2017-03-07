using NationalRailViewer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace NationalRailViewer.Web
{
    public static class DataRequester
    {
        public static StationDataResponse GetStationData(string serviceURL, string station, RequestDataTypeEnum requestDataType)
        {
            StationDataResponse response = new StationDataResponse();
            response.ResponseStatus = ResponseStatusTypeEnum.Success;

            Uri requestUri = new Uri(string.Format("{0}/{1}/{2}", serviceURL, requestDataType.ToString().ToLower(), station));

            WebClient client = new WebClient();
            string content = string.Empty;

            try
            {
                content = client.DownloadString(requestUri);
            }
            catch (Exception)
            {
                response.ResponseStatus = ResponseStatusTypeEnum.Error;
            }

            if (!string.IsNullOrEmpty(content))
            {
                QueryResult data = JsonConvert.DeserializeObject<QueryResult>(content);
                response.Data = data;
            }
            else
            {
                response.ResponseStatus = ResponseStatusTypeEnum.NoData;
            }
            
            return response;
        }
    }
}