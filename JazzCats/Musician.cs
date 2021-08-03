using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzCatsREPO
{
    public enum StyleType
    {
        Swing = 1,
        Straight_Ahead = 2,
        Bop = 3,
        Fusion = 4,
        Soul = 5,
    }

    public abstract class Musician
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Instrument { get; set; }

        public StyleType TypeofStyle { get; set; }

        public bool IsStillLiving { get; set; }
        public bool IsCurrentlyTouring { get; set; }
        public bool ReleasingNewAlbum { get; set; }
        public bool OnSpotify { get; set; }

        public Musician()
        {

        }

        public Musician(string firstName, string lastName, string instrument, StyleType style, bool isStillLiving, bool isCurrentlyTouring, bool releasingNewAlbum, bool onSpotify)
        {
            FirstName = firstName;
            LastName = lastName;
            Instrument = instrument;
            TypeofStyle = style;
            IsStillLiving = isStillLiving;
            IsCurrentlyTouring = isCurrentlyTouring;
            ReleasingNewAlbum = releasingNewAlbum;
            OnSpotify = onSpotify;
        }
    }
}