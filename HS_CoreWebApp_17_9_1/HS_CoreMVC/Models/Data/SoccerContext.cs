using Microsoft.EntityFrameworkCore;

namespace HS_CoreMVC.Models.Data
{
    public class SoccerContext : DbContext
    {
        public SoccerContext(DbContextOptions<SoccerContext> options)
            : base(options)
        { }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
