using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard.RocketsLegends
{
    public class RocketsPlayer : BallPlayer
    {
        public RocketsPlayer() { }

        public RocketsPlayer(string firstName, string lastName, int number, string team, string nickname) :
           base(firstName, lastName, number, team, nickname)
        {

        }
    }
}
