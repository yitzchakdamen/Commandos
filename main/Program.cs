
using Commandos.Interface;

namespace Commandos
{
    class Program
    {
        public static void Main()
        {

            // List<ISoldier> ListInitialization = Initialization();
            // SystemManagement SystemManagement = new(ListInitialization);
            // Tests(SystemManagement);
        }



        public static void Tests(SystemManagement systemManagement)
        {
            foreach (var item in systemManagement.ListSoldiers)
            {
                Console.WriteLine("===================");
                Console.WriteLine(item.Status);
                item.Hide();
                // item.Attak();
                Console.WriteLine(item.Status);
                Console.WriteLine(item.CodeName);
                Console.WriteLine(item.SayName("GENERAL"));
                Console.WriteLine(item.SayName("COLONEL"));
                Console.WriteLine(item.SayName(""));
                Console.WriteLine("===================");
            }
            
        }        
    }
    
}