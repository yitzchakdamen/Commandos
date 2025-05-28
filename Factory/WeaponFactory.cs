using Commandos.WeaponArea;

namespace Commandos.Factory
{
    class WeaponFactory
    {
        static Knife knife = new("name", "color", 2, "manufacturer", "metalType");
        static Pistols pistols = new("name", "manufacturer", 5);
        static Guns guns = new("name", "manufacturer");
        static Stone stone = new("name", "color");

        static public List<IShootable> ListShootable = new() {guns, pistols };
        static public List<IBreakable> ListBreakable = new() { knife, stone};

    }
    
}