using System.Collections.Generic;

namespace HS_CoreMVC.Models.Data
{
    public class League
    {
        // cols
        public int Id { get; set; }
        public string Name { get; set; }
        // FKs

        // refs
        public List<Team> Teams { get; set; }
    }
}
