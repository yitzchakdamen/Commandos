namespace Commandos.WeaponArea
{
    class Knife : Weapon, IBreakable
    {
        public int Weight;
        public string Color;
        public string MetalType;
        public string Manufacturer { get; set; }
        public bool Status { get; set; } = true;
        public int NumOfMaxHits { get; set; } = 50;
        public int NumOfMaxNow { get; set; } = 0;

        public Knife(string name, string color, int weight, string manufacturer, string metalType) : base(name)
        {
            Color = color;
            Weight = weight;
            Manufacturer = manufacturer;
            MetalType = metalType;
        }
    }
}
 

