using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard.CelticsLegends
{
    public class CelticsPlayer : BallPlayer
    {
        public CelticsPlayer() { }

        public CelticsPlayer(string firstName, string lastName, int number, string team, string nickname) :
           base(firstName, lastName, number, team, nickname)
        {

        }
    }
}
