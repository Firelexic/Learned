using System;
using System.Collections.Generic;
using System.Linq;

namespace SumWithGroupBy
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int Score { get; set; }
    }

    class SumWithGroupBy
    {
        static void Main()
        {
            var players = new List<Player>
            {
             new Player { Name = "Alex", Team = "A", Score = 10 },
             new Player { Name = "Anna", Team = "A", Score = 20 },
             new Player { Name = "Luke", Team = "L", Score = 60 },
             new Player { Name = "Lucy", Team = "L", Score = 40 },
            };

            var teamTotalScores =
                from player in players
                group player by player.Team into playerGroup
                select new
                {
                    Team = playerGroup.Key,
                    TotalScore = playerGroup.Sum(x => x.Score),
                    
                };
            Console.WriteLine(teamTotalScores);
        }
    }
}
