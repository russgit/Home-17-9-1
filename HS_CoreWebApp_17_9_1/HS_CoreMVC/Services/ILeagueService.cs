using HS_CoreMVC.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_CoreMVC.Services
{
    public interface ILeagueService
    {
        League AddLeague(string name);
        void GetLeague(int id);
        void GetLeagues();
    }
}
