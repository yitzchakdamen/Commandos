namespace Commandos.WeaponArea
{
    class Guns : Weapon, IShootable
    {
        public string Manufacturer { get; set; }
        public int NumOfBullets { get; set; } = 100;
        public Guns(string name, string manufacturer) : base(name)
        {
            Manufacturer = manufacturer;
        }
        public void Shoot()
        {
            Console.WriteLine("BOOOOM");
            NumOfBullets -= 20;
        }

        public void AddBullets()
        {
            NumOfBullets += 100;
        }
        
    }
    
}