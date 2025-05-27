using Commandos.Interface;
using Commandos.EnemyArea;

namespace Commandos
{
    class AirCommando : Soldier, IAirCommando
    {
        public AirCommando(string name, string codeName) : base(name, codeName)
        {

        }

        public void Parachuting()
        {
            Print("Parachuting");
        }
        
        public override void Attak(Enemy e)
        {
            base.Attak(e);
            Console.WriteLine("The attack was carried out by AirCommando");
        } 

    }

    class SeaCommando : Soldier, ISeaCommando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName)
        {

        }

        public void Swimming()
        {
            Print("Swimming");
        }

        public override void Attak(Enemy e)
        {
            base.Attak(e);
            Console.WriteLine("The attack was carried out by SeaCommando");
        } 
    }

}