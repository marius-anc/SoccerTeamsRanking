using System;
using Xunit;

namespace SoccerTeamsRanking.Tests
{
    public class ProgramsTests
    {
        [Fact]
        public void BubbleSortsWorksWithSimpleArray()
        {
            SoccerTeam[] teams = { new SoccerTeam("FCSB", 33), new SoccerTeam("Sepsi OSK ", 28), new SoccerTeam("CS Gaz Metan Medias", 29) };
            SoccerTeam[] teamsSorted = { new SoccerTeam("FCSB", 33),  new SoccerTeam("CS Gaz Metan Medias", 29), new SoccerTeam("Sepsi OSK ", 28) };
            Program.BubbleSort(teams);
            Assert.Equal<SoccerTeam>(teams, teamsSorted);

        }
    }
}
