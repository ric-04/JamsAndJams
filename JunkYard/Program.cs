using JazzCatsREPO;
using JazzCatsREPO.Bop;
using JazzCatsREPO.Fusion;
using JazzCatsREPO.Straight_Ahead;
using JazzCatsREPO.Swing;
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
    class Program
    {
        static void Main(string[] args)
        {
            //SwingMusician DReinhardt = new SwingMusician("Django", "Reinhardt", "guitar", StyleType.Swing, false, false, false, true);
            //Straight_AheadMusician OPeterson = new Straight_AheadMusician("Oscar", "Peterson", "piano", StyleType.Straight_Ahead, false, false, false, true);
            //BopMusician PChambers = new BopMusician("Paul", "Chambers", "bass", StyleType.Bop, false, false, false, true);
            //FusionMusician FHubbard = new FusionMusician("Freddie", "Hubbard", "trumpet", StyleType.Fusion, false, false, false, true);
            //SoulMusician LSmith = new SoulMusician("Lonnie", "Smith", "organ", StyleType.Soul, true, false, false, true);

            //// Set Up Dictionary
            //Dictionary<int, Musician> musicians = new Dictionary<int, Musician>();

            //// Assign Values to Dictionary
            //musicians.Add(1, DReinhardt);
            //musicians.Add(2, OPeterson);
            //musicians.Add(3, PChambers);
            //musicians.Add(4, FHubbard);
            //musicians.Add(5, LSmith);

            //// Do Work -> This version is Key Value Pair
            //foreach (var musician in musicians)
            //{
            //    Console.WriteLine(musician.Key);
            //    Console.WriteLine(musician.Value.FirstName);
            //    Console.WriteLine(musician.Value.LastName);
            //    Console.WriteLine(musician.Value.Instrument);
            //    Console.WriteLine(musician.Value.TypeofStyle);
            //    Console.WriteLine(musician.Value.IsStillLiving);
            //}

            //Console.WriteLine("-----------------------------------------");

            //foreach (var musician in musicians)
            //{
            //    if (musician.Key == 3)
            //    {
            //        Console.WriteLine(musician.Value.FirstName);
            //        Console.WriteLine(musician.Value.LastName);
            //        Console.WriteLine(musician.Value.IsStillLiving);
            //    }
            //}

            //Console.WriteLine("---------------------------------------");

            //// Do Work -> KEYS
            //foreach (var musician in musicians.Keys)
            //{
            //    Console.WriteLine(musician);
            //}

            //foreach (var musician in musicians.Keys)
            //{
            //    if (musician == 4)
            //    {
            //        Console.WriteLine(musician);
            //    }
            //}
            //Console.WriteLine("--------------------------------------");

            //// Do Work -> VALUES
            //foreach (var musician in musicians.Values)
            //{
            //    Console.WriteLine(musician.FirstName);
            //    Console.WriteLine(musician.LastName);
            //    Console.WriteLine(musician.Instrument);
            //    Console.WriteLine(musician.TypeofStyle);
            //    Console.WriteLine(musician.IsStillLiving);
            //    Console.WriteLine(musician.IsCurrentlyTouring);
            //    Console.WriteLine(musician.ReleasingNewAlbum);
            //    Console.WriteLine(musician.OnSpotify);
            //}

            //Console.WriteLine("--------------------------------------");
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //dictionary.Add("apple", "What humans eat.");
            //dictionary.Add("Black Eyed Peas", "What humans eat. Well, some of them.");

            //foreach (var def in dictionary)
            //{
            //    Console.WriteLine(def.Key);
            //    Console.WriteLine(def.Value);
            //}
            DictionaryPractice.CreatePlayers();
      //  }
            Console.ReadKey();
            
            
        }


}
}