using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalRailViewer.Model
{
    [JsonObject]
    public class QueryResult : IEnumerable, IQueryResult
    {
        public TrainServices[] trainServices { get; set; }

        public IEnumerator GetEnumerator()
        {
            foreach (var ts in trainServices)
            {
                if (ts == null)
                {
                    break;
                }

                yield return ts;
            }
        }
    }
}
