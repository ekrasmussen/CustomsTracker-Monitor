namespace CustomsTracker_Monitor.Model.APIModel
{
    public class PlayerLocationsOnPlant
    {
        public string Player_Puuid { get; set; }
        public string Player_Display_Name { get; set; }
        public string Player_Team { get; set; }
        public Location Location { get; set; }
        public double View_Radians { get; set; }
    }
}