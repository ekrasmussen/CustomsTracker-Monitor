namespace CustomsTracker_Monitor.Model.APIModel
{
    public class PlantEvents
    {
        public PlantLocation Plant_Location { get; set; }
        public PlantedBy Planted_By { get; set; }
        public string Plant_Site { get; set; }
        public int? Plant_Time_In_Round { get; set; }
        public List<PlayerLocationsOnPlant> Player_Locations_On_Plant { get; set; }
    }
}