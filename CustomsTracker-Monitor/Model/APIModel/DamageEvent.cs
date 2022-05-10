namespace CustomsTracker_Monitor.Model.APIModel
{
    public class DamageEvent
    {
        public string Receiver_Puuid { get; set; }
        public string Receiver_Display_Name { get; set; }
        public string Receiver_Team { get; set; }
        public int? Bodyshots { get; set; }
        public int? Damage { get; set; }
        public int? Headshots { get; set; }
        public int? Legshots { get; set; }
    }
}