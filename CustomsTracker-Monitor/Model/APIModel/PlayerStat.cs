namespace CustomsTracker_Monitor.Model.APIModel
{
    public class PlayerStat
    {
        public AbilityCasts Ability_Casts { get; set; }
        public string Player_Puuid { get; set; }
        public string Player_Display_Name { get; set; }
        public string Player_Team { get; set; }
        public List<DamageEvent> Damage_Events { get; set; }
        public int? Damage { get; set; }
        public int? Bodyshots { get; set; }
        public int? Headshots { get; set; }
        public int? Legshots { get; set; }
        public List<KillEvent> Kill_Events { get; set; }
        public int? Kills { get; set; }
        public int? Score { get; set; }
        public Economy Economy { get; set; }
        public bool Was_Afk { get; set; }
        public bool Was_Penalized { get; set; }
        public bool Stayed_In_Spawn { get; set; }
    }
}