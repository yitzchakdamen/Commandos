using Commandos.EnemyArea;

namespace Commandos.Factory
{
    static public class EnemyFactory
    {
        static public Random random = new();
        static List<string> terroristNames = new()
        {
            "Khalid Al-Masri",
            "Yusuf Karim",
            "Rashid Al-Hassan",
            "Ivan Petrov",
            "Miguel Cortez",
            "Li Zhang",
            "Fatima El-Amin",
            "Viktor Dragunov",
            "Jamal Al-Zahir",
            "Carlos Mendoza"
        };

        static public List<Enemy> ListEnemy;

        static public void initialization()
        {
            ListEnemy = ProducesEnemy();
        }

        static public List<Enemy> ProducesEnemy()
        {
            int amount = random.Next(10, 20);
            List<Enemy> ListEnemy = new();

            for (int i = 0; i < amount; i++)
            {
                string name = terroristNames[random.Next(0, terroristNames.Count)];
                Enemy enemy = new(name);
                ListEnemy.Add(enemy);
            }
            return ListEnemy;
        }
    }
    
}