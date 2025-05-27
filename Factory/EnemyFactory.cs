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

        static public List<Enemy> ListEnemy = new();

        static public void initialization()
        {
            ListEnemy = ProducesEnemy();
        }

        static public List<Enemy> ProducesEnemy()
        {
            for (int i = 0; i < random.Next(10, 20); i++)
            {
                string name = terroristNames[random.Next(0, terroristNames.Count)];
                Enemy enemy = new(name);
                ListEnemy.Add(enemy);
            }
            return ListEnemy;
        }
    }
    
}