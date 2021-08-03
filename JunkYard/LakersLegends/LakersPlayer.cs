using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard.LakersLegends
{
    public class LakersPlayer : BallPlayer
    {
        public LakersPlayer() { }

        public LakersPlayer(string firstName, string lastName, int number, string team, string nickname) :
           base (firstName, lastName, number, team, nickname)
        {

        }
    }
}
