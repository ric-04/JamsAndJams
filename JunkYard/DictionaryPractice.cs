using JunkYard.BullsLegends;
using JunkYard.CelticsLegends;
using JunkYard.LakersLegends;
using JunkYard.PistonsLegends;
using JunkYard.RocketsLegends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard
{
    public  static class DictionaryPractice
    {
      public  static void CreatePlayers()
        {
            BullsPlayer MJordan = new BullsPlayer("Michael", "Jordan", 23, "Chicago Bulls", "Air Jordan");
            LakersPlayer MJohnson = new LakersPlayer("Earvin", "Johnson", 32, "Los Angeles Lakers", "Magic");
            CelticsPlayer LBird = new CelticsPlayer("Larry", "Bird", 33, "Boston Celtics", "Larry Legend");
            PistonsPlayer IThomas = new PistonsPlayer("Isaiah", "Thomas", 11, "Detroit Pistons", "Zeke");
            RocketsPlayer HOlajuwon = new RocketsPlayer("Hakeem", "Olajuwon", 34, "Houston Rockets", "The Dream");

            // Set Up Dictionary
            Dictionary<int, BallPlayer> ballPlayers = new Dictionary<int, BallPlayer>();

            // Assign Values to Dictionary
            ballPlayers.Add(1, MJordan);
            ballPlayers.Add(2, MJohnson);
            ballPlayers.Add(3, LBird);
            ballPlayers.Add(4, IThomas);
            ballPlayers.Add(5, HOlajuwon);

            foreach (var ballPlayer in ballPlayers)
            {
             // Console.WriteLine(ballPlayer.Key);
                Console.WriteLine(ballPlayer.Value.Nickname);
                Console.WriteLine(ballPlayer.Value.Number);
                Console.WriteLine(ballPlayer.Value.Team);
            }
        }
    }
}

