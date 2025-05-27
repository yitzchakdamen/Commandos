
using Commandos.Interface;

namespace Commandos
{
    class Program
    {
        public static void Main()
        {

            List<ICommando> ListInitialization = Initialization();
            SystemManagement SystemManagement = new(ListInitialization);
            Tests(SystemManagement);
        }

        public static List<ICommando> Initialization()
        {
            Commando Commando1 = new("nameB", "a");
            Commando Commando2 = new("nameA", "b");
            AirCommando AirCommando = new("AirCommando", "c");
            SeaCommando SeaCommando = new("SeaCommando", "e");
            return new List<ICommando>() { Commando1, Commando2, AirCommando, SeaCommando };
        }

        public static void Tests(SystemManagement systemManagement)
        {
            foreach (var item in systemManagement.ListSoldiers)
            {
                Console.WriteLine("===================");
                item.Hide();
                item.Attak();
                Console.WriteLine(item.CodeName);
                Console.WriteLine(item.GetName("GENERAL"));
                Console.WriteLine(item.GetName("COLONEL"));
                Console.WriteLine(item.GetName(""));
                Console.WriteLine("===================");
            }
            
        }        
    }
    
}