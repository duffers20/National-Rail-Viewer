namespace NationalRailViewer.Model
{
    public interface IJourney
    {
        string locationName { get; set; }
        string crs { get; set; }
        string via { get; set; }
        string futureChangeTo { get; set; }
        bool assocIsCancelled { get; set; }
    }
}
