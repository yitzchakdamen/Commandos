using Commandos.Factory;
using Commandos.Interface;
using Commandos.EnemyArea;

namespace Commandos
{
    public class Game
    {
        public SystemManagement systemManagement = new();
        public List<Enemy> ListEnemy;

        public Game()
        {
            for (int i = 0; i < 3; i++)
            {
                SoldierFactory.Initialization();
                systemManagement.Add(SoldierFactory.ListSoldier);
            }

            EnemyFactory.initialization();
            ListEnemy = EnemyFactory.ListEnemy;
        }
        
        

    }
}