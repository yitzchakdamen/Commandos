
using Commandos.Interface;

namespace Commandos
{
    class Program
    {
        public static void Main()
        {

            Game game = new();

            Tests(game.systemManagement);
            Tests2(game);
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

        public static void Tests2(Game game)
        {
            foreach (var item in game.ListEnemy)
            {
                Console.WriteLine("===================");
                Console.WriteLine(item.Name);

                Console.WriteLine("===================");
            }
        }
    }
    
}