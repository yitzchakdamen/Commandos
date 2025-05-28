namespace Commandos.WeaponArea
{
    class Pistols : Weapon, IShootable
    {
        public string Manufacturer { get; set; }
        public int NumOfBullets { get; set; } = 20;
        public Pistols(string name, string manufacturer, int numOfBullets) : base(name)
        {
            Manufacturer = manufacturer;
            NumOfBullets = numOfBullets;
        }
        public void Shoot()
        {
            Console.WriteLine("BOOOOM");
            NumOfBullets -= 3;
        }

        public void AddBullets()
        {
            NumOfBullets += 20;
        }

        
        
    }
    
}