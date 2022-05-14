namespace CustomsTracker_Monitor.Model.APIModel
{
    public class DefuseEvents
    {
        public DefuseLocation Defuse_Location { get; set; }
        public DefusedBy Defused_By { get; set; }
        public int? Defuse_Time_In_Round { get; set; }
        public List<PlayerLocationsOnDefuse> Player_Locations_On_Defuse { get; set; }
    }
}