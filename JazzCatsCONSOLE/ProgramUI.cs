using JazzCatsREPO;
using JazzCatsREPO.Bop;
using JazzCatsREPO.Fusion;
using JazzCatsREPO.Swing;
using JazzCatsREPO.Straight_Ahead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunkYard;

namespace JazzCatsCONSOLE
{
    class ProgramUI
    {
        private MusicianREPO _musicianREPO = new MusicianREPO();

        public void Run()
        {
           SeedMusicians();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Welcome to the Jazz Vaults. What would you like to do?\n" +
                    "1] Search Artist by LAST NAME\n" +
                    "2] Search Artist by FIRST NAME\n" +
                    "3] Search Artist by INSTRUMENT\n" +
                    "4] Search Artist by STYLE\n" +
                    "5] View All Artists\n"+
                    "0] Exit\n");

                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "1":
                        SearchLastName();
                        break;
                    case "2":
                        SearchFirstName();
                        break;
                    case "3":
                        SearchInstrument();
                        break;
                    case "4":
                        SearchStyle();
                        break;
                    case "5":
                        ViewAllArtists();
                        break;
                    case "0":
                        keepRunning = false;
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void ViewAllArtists()
        {
            Console.Clear();
           
            List<Musician> musician = _musicianREPO.GetAllMusicians();
            foreach (var m in musician)
            {
                _musicianREPO.GetArtistInfo(m);
            }
        }

        private void SearchStyle()
        {
            Console.Clear();
            Musician musician;
            Console.WriteLine("Please select style.\n" +
                "1] Swing\n"+
                "2] Straight Ahead\n"+
                "3] Bop\n"+
                "4] Fusion\n"+
                "5] Soul");

            int userInput = int.Parse(Console.ReadLine());
            StyleType style = (StyleType)userInput;
           
            switch (style)
            {
                case StyleType.Swing:
                   
                    Console.Clear();
                     musician = _musicianREPO.MusicianByStyleType(StyleType.Swing);
                    _musicianREPO.GetArtistInfo(musician);
                    break;

                case StyleType.Straight_Ahead:
                    
                    Console.Clear();
                     musician = _musicianREPO.MusicianByStyleType(StyleType.Straight_Ahead);
                    _musicianREPO.GetArtistInfo(musician);
                    break;

                case StyleType.Bop:
                   
                    Console.Clear();
                    musician = _musicianREPO.MusicianByStyleType(StyleType.Bop);
                    _musicianREPO.GetArtistInfo(musician);
                    break;

                case StyleType.Fusion:
                    
                    Console.Clear();
                    musician = _musicianREPO.MusicianByStyleType(StyleType.Fusion);
                    _musicianREPO.GetArtistInfo(musician);
                    break;

                case StyleType.Soul:

                    Console.Clear();
                    musician = _musicianREPO.MusicianByStyleType(StyleType.Soul);
                    _musicianREPO.GetArtistInfo(musician);
                    break;

                default:
                    Console.WriteLine("Please make another selection.");
                    break;
            }
        }

        private void SearchInstrument()
        {
            Console.Clear();
            Console.WriteLine("Please input INSTRUMENT");
            string userInput = Console.ReadLine();
            Console.Clear();
            Musician musician = _musicianREPO.MusicianByInstrument(userInput);
            _musicianREPO.GetArtistInfo(musician);
        }

        private void SearchFirstName()
        {
            throw new NotImplementedException();
        }

        private void SearchLastName()
        {
            throw new NotImplementedException();
        }

        private void SeedMusicians()
        {
            SwingMusician DReinhardt = new SwingMusician("Django", "Reinhardt", "guitar", StyleType.Swing, false, false, false, true);
            Straight_AheadMusician OPeterson = new Straight_AheadMusician("Oscar", "Peterson", "piano",StyleType.Straight_Ahead, false, false, false, true);
            BopMusician PChambers = new BopMusician("Paul", "Chambers", "bass", StyleType.Bop, false, false, false, true);
            FusionMusician FHubbard = new FusionMusician("Freddie", "Hubbard", "trumpet", StyleType.Fusion, false, false, false, true);
            SoulMusician LSmith = new SoulMusician("Lonnie", "Smith", "organ", StyleType.Soul, true, false, false, true);

           //DictionaryPractice.CreatePlayers();

            _musicianREPO.AddMusicianToList(DReinhardt);
            _musicianREPO.AddMusicianToList(OPeterson);
            _musicianREPO.AddMusicianToList(PChambers);
            _musicianREPO.AddMusicianToList(FHubbard);
            _musicianREPO.AddMusicianToList(LSmith);
        }
    }
}