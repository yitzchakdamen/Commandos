using Commandos;
using Commandos.Interface;

namespace Commandos.Factory
{
    public class SoldierFactory
    {
        static public List<ISoldier> ListSoldier;

        static public void Initialization()
        {
            System.Console.WriteLine("Choose the type of soldier to produce");
            System.Console.WriteLine("1 ==> Soldier");
            System.Console.WriteLine("2 ==> Air Commando");
            System.Console.WriteLine("3 ==> Sea Commando");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    ListSoldier = ProducesSoldier();
                    break;

                case "2":
                    ListSoldier = ProducesAirCommando();
                    break;

                case "3":
                    ListSoldier = ProducesSeaCommando();
                    break;

                default:
                    System.Console.WriteLine("Wrong choice");
                    break;
            }
        }

       static List<ISoldier> ProducesSoldier()
        {
            Soldier Commando1 = new("nameB", "a");
            Soldier Commando2 = new("nameA", "b");
            return new List<ISoldier>() { Commando1, Commando2, };

        }

        static List<ISoldier> ProducesAirCommando()
        {
            AirCommando AirCommando1 = new("AirCommando", "c");
            AirCommando AirCommando2 = new("AirCommando", "d");

            return new List<ISoldier>() { AirCommando1, AirCommando2 };
        }
        
        static List<ISoldier> ProducesSeaCommando()
        {
            SeaCommando SeaCommando1 = new("SeaCommando", "c");
            SeaCommando SeaCommando2 = new("SeaCommando", "d");

            return new List<ISoldier>() { SeaCommando1, SeaCommando2 };
        }

    } 
}