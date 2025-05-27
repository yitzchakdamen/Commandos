using Commandos.Interface;

namespace Commandos
{
    class AirCommando : Commando, IAirCommando
    {
        public AirCommando(string name, string codeName) : base(name, codeName)
        {

        }

        public void Parachuting()
        {
            Print("Parachuting");
        }
        
        public override void Attak()
        {
            base.Attak();
            Console.WriteLine("The attack was carried out by AirCommando");
        } 

    }

    class SeaCommando : Commando, ISeaCommando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName)
        {

        }

        public void Swimming()
        {
            Print("Swimming");
        }

        public override void Attak()
        {
            base.Attak();
            Console.WriteLine("The attack was carried out by SeaCommando");
        } 
    }

}