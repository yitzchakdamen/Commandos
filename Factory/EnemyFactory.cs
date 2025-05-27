using Commandos.EnemyArea;

namespace Commandos.Factory
{
    class EnemyFactory
    {
        public Random random = new();
        List<string> terroristNames = new()
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

        public List<Enemy> ProducesEnemy()
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