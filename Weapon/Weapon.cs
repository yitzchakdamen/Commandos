using Commandos.Interface;

namespace Commandos
{
    class Weapon : IWeapon
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int NumOfBullets { get; set; }
        public Weapon(string name, string manufacturer, int numOfBullets)
        {
            Name = name;
            Manufacturer = manufacturer;
            NumOfBullets = numOfBullets;
        }
        public void Shoot()
        {
            Console.WriteLine("BOOOOM");
            NumOfBullets -= 1;
        }
        
    }
    
}