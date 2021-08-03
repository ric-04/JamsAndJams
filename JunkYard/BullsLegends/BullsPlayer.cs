using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard.BullsLegends
{
    public class BullsPlayer : BallPlayer
    {
        public BullsPlayer() { }
        public BullsPlayer (string firstName, string lastName, int number, string team, string nickname) :
           base (firstName, lastName, number, team, nickname)
        {

        } 
    }
}
