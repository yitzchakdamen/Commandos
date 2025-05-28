using Commandos.Interface;

namespace Commandos.WeaponArea
{
    class Weapon : IWeapon
    {
        public string Name { get; set; }
        public Weapon(string name)
        {
            Name = name;
        }
        
    }
    
}