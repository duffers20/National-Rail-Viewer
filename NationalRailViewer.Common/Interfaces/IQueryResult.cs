using System.Collections.Generic;

namespace NationalRailViewer.Model
{
    public interface IQueryResult
    {
        TrainServices[] trainServices { get; set; }
    }
}