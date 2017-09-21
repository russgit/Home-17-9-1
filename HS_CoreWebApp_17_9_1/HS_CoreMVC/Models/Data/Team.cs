namespace HS_CoreMVC.Models.Data
{
    public class Team
    {
        // cols
        public int Id { get; set; }
        public string Name { get; set; }
        // FKs
        public int LeagueId { get; set; }

        // refs
    }
}
