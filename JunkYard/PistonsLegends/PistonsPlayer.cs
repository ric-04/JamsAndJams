using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard.PistonsLegends
{
    public class PistonsPlayer : BallPlayer
    {
        public PistonsPlayer() { }

        public PistonsPlayer(string firstName, string lastName, int number, string team, string nickname) :
           base (firstName, lastName, number, team, nickname)
        {

        } 
    }
}
