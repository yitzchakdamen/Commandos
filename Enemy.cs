namespace Commandos.EnemyArea
{
    public class Enemy
    {
        public string Name;
        public int Life;
        public bool StatusLife;

        public Enemy(string name)
        {
            Name = name;
            Life = 100;
            StatusLife = true;
        }

        static public void Shout()
        {
            Console.WriteLine("======== I am a enemy!!! ======== ");
        }
    }
    
}