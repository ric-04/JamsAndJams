using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzCatsREPO
{
    public class MusicianREPO
    {
        private readonly List<Musician> musicianDatabase = new List<Musician>();

        // Create
        public void AddMusicianToList(Musician musician)
        {
            musicianDatabase.Add(musician);
        }

        // Read
        public List<Musician> GetAllMusicians()
        {
            return musicianDatabase;
        }


        // Update

        // Delete

        // Find by Last Name
        public Musician MusicianByLastName(string lastName)
        {
            foreach (var musician in musicianDatabase)
            {
                if (musician.LastName== lastName)
                {
                    return musician;
                }
            }

            return null;
        }

        // Find by First Name
        public Musician MusicianByFirstName(string firstName)
        {
            foreach (var musician in musicianDatabase)
            {
                if (musician.FirstName == firstName)
                {
                    return musician;
                }
            }

            return null;
        }

        // Find by Instrument
        public Musician MusicianByInstrument(string Instrument)
        {
            foreach (var musician in musicianDatabase)
            {
                if (musician.Instrument == Instrument)
                {
                    return musician;
                }
            }

            return null;
        }

        // Find by Style
        public Musician MusicianByStyleType(StyleType style)
        {
            foreach (var musician in musicianDatabase)
            {
                if (musician.TypeofStyle == style)
                {
                    return musician;
                }
            }

            return null;
        }

        // View Artist Info
        public void GetArtistInfo(Musician musician)
        {
            Console.WriteLine($"{musician.FirstName} {musician.LastName}\n" +
                $"{musician.Instrument}\n" +
                $"{musician.TypeofStyle}\n" +
                $"{musician.IsStillLiving}\n"+
                $"{musician.IsCurrentlyTouring}\n"+
                $"{musician.ReleasingNewAlbum}\n"+
                $"{musician.OnSpotify}\n"+
                $"--------------------------------------");
        }

    }
}