using Commandos.Factory;
using Commandos.Interface;
using Commandos.EnemyArea;

namespace Commandos
{
    public class Game
    {

        public List<Enemy> ListEnemy;
        public List<ISoldier> ListSoldiers;

        public Game()
        {
            for (int i = 0; i < 3; i++)
            {
                SoldierFactory.Initialization();
            }
            ListSoldiers = SoldierFactory.ListSoldier;


            EnemyFactory.initialization();
            ListEnemy = EnemyFactory.ListEnemy;
        }

        public void AttackExecution(ISoldier soldier)
        {
            Enemy Enemy = ListEnemy[new Random().Next(0, ListEnemy.Count)];
            if (Enemy.StatusLife)
            {
                soldier.Attak(Enemy);
                return;
            }
            Console.WriteLine("Enemy is NOT in Life");
            

        }
        
        

    }
}