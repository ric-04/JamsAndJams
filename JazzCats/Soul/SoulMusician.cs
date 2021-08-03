using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzCatsREPO
{
    public class SoulMusician: Musician
    {
        public SoulMusician()
        {

        }
        public SoulMusician(string firstName, string lastName, string instrument, StyleType style, bool isStillLiving, bool isCurrentlyTouring, bool releasingNewAlbum, bool onSpotify) :
            base(firstName, lastName, instrument, style, isStillLiving, isCurrentlyTouring, releasingNewAlbum, onSpotify)
        {

        }
    }
}