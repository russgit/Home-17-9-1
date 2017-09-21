using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HS_CoreMVC.Services;
using HS_CoreMVC.Models.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HS_CoreMVC.Controllers.Api
{
    //[Route("api/[controller]")]
    [Route("api/v1/league")]
    public class LeagueController : Controller
    {
        ILeagueService _leagueService;

        public LeagueController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }

        /// <summary>
        /// Add a league with the name passed; 200 works, 500 fails
        /// TODO: some useful Exception handling
        /// </summary>
        /// <remarks>
        /// POST api/vi/
        /// </remarks>
        [HttpPost]
        public JsonResult AddLeague([FromForm]string name)
        {
            // TODO: use biz object not DbSet type for the return value from service layer
            League newLeague;

            try {
                newLeague = _leagueService.AddLeague(name);
            }
            catch (Exception ex) {
                throw ex;
            }
            return new JsonResult(newLeague) { StatusCode = 200 };
        }

        [HttpGet]
        public IEnumerable<string> GetLeagues()
        {
            throw new NotImplementedException("TODO: GetLeagues");
        }
        [HttpGet("{id}")]
        public string GetLeague(int id)
        {
            throw new NotImplementedException("TODO: GetLeague");
        }
        [HttpPut("{id}")]
        public void UpdateLeague(int id, [FromBody]string someStuffGoesHere)
        {
            throw new NotImplementedException("TODO: UpdateLeague");
        }
        [HttpDelete("{id}")]
        public void DeleteLeague(int id)
        {
            throw new NotImplementedException("TODO: DeleteLeague");
        }
    }
}
