using HS_CoreMVC.Models.Data;
using HS_CoreMVC.Services;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace TestHsCoreMVC.Services
{
    public class LeagueTest
    {
        [Fact]
        public void TestAddLeague()
        {
            // arrange
            SoccerContext testDbContext = this.SetDbContext();
            LeagueService testService = new LeagueService(testDbContext);

            // act
            League newLeague = testService.AddLeague("please make sure I am deleted League");

            // assert
            Assert.NotEmpty(newLeague.Name);
            Assert.True(newLeague.Id > 0, "Doh!");
            Assert.True(newLeague.Teams.Count == 0);
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
