namespace CustomsTracker_Monitor.Model.APIModel
{
    public class Kill
    {
        public int Kill_Time_In_Round { get; set; }
        public int Kill_Time_In_Match { get; set; }
        public int Round { get; set; }
        public string Killer_Puuid { get; set; }
        public string Killer_Display_Name { get; set; }
        public string Killer_Team { get; set; }
        public string Victim_Puuid { get; set; }
        public string Victim_Display_name { get; set; }
        public string Victim_Team { get; set; }
        public VictimDeathLocation Victim_Death_Location { get; set; }
        public string Damage_Weapon_ID { get; set; }
        public string Damage_Weapon_Name { get; set; }
        public DamageWeaponAssets Damage_Weapon_Assets { get; set; }
        public bool Secondary_Fire_Mode { get; set; }
        public List<PlayerLocationsOnKill> Player_Locations_All_Kill { get; set; }
        public List<Assistant> Assistants { get; set; }
    }
}