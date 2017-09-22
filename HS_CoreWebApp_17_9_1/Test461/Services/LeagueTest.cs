using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HS_CoreMVC.Models.Data;
using Microsoft.EntityFrameworkCore;
using HS_CoreMVC.Services;

namespace Test461
{
    [TestClass]
    public class LeagueTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            SoccerContext testDbContext = this.SetDbContext();
            LeagueService testService = new LeagueService(testDbContext);

            // act
            League newLeague = testService.AddLeague("please make sure I am deleted League");

            // assert
            Assert.IsNotNull(newLeague.Name);
            Assert.IsTrue(newLeague.Id > 0, "Doh!");
            Assert.IsTrue(newLeague.Teams.Count == 0);
        }

        private SoccerContext SetDbContext()
        {
            var options = new DbContextOptionsBuilder<SoccerContext>()
                                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                                .Options;
            var mockishDbContext = new SoccerContext(options);
            return mockishDbContext;
        }
    }
}
