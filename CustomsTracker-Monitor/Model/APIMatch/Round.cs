namespace CustomsTracker_Monitor.Model.APIModel
{
    public class Round
    {
        public string Winning_Team { get; set; }
        public string End_Type { get; set; }
        public bool Bomb_Planted { get; set; }
        public bool Bomb_Defused { get; set; }
        public PlantEvents Plant_Events { get; set; }
        public DefuseEvents Defuse_Events { get; set; }
        public List<PlayerStat> Player_Stats { get; set; }
    }
}