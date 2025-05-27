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
    }

}