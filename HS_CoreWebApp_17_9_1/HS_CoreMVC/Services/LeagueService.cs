using HS_CoreMVC.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_CoreMVC.Services
{
    public class LeagueService : ILeagueService
    {
        private SoccerContext _dbContext;

        public LeagueService(SoccerContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <remarks>
        /// restrict dups in schema or check or something, don't allow
        /// </remarks>
        ///
        public League AddLeague(string name)
        {
            League newLeague = new League()
            {
                Name = name,
            };

            _dbContext.Leagues.Add(newLeague);
            _dbContext.SaveChanges();

            return newLeague;
        }

        public void GetLeague(int id)
        {
            throw new NotImplementedException();
        }

        public void GetLeagues()
        {
            throw new NotImplementedException();
        }
    }
}
