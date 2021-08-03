using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard
{
    public abstract class BallPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public string Team { get; set; }
        public string Nickname { get; set; }
        public BallPlayer() { }

        public BallPlayer(string firstName, string lastName, int number, string team, string nickname)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            Team = team;
            Nickname = nickname;
        }
    }
}