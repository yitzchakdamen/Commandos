using Commandos;
using Commandos.Interface;

namespace Commandos.Factory
{
    class SoldierFactory
    {
        public List<ISoldier> ProducesSoldier()
        {
            Soldier Commando1 = new("nameB", "a");
            Soldier Commando2 = new("nameA", "b");
            return new List<ISoldier>() { Commando1, Commando2, };

        }

        public List<ISoldier> ProducesAirCommando()
        {
            AirCommando AirCommando1 = new("AirCommando", "c");
            AirCommando AirCommando2 = new("AirCommando", "d");

            return new List<ISoldier>() { AirCommando1, AirCommando2 };
        }
        
        public List<ISoldier> ProducesSeaCommando()
        {
            SeaCommando SeaCommando1 = new("AirCommando", "c");
            SeaCommando SeaCommando2 = new("AirCommando", "d");

            return new List<ISoldier>() { SeaCommando1, SeaCommando2 };
        }

    } 
}