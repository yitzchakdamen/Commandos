namespace Commandos.WeaponArea
{
    class Stone : Weapon, IBreakable
    {
        public int Weight;
        public string Color;
        public bool Status { get; set; } = true;
        public int NumOfMaxHits { get; set; } = 50;
        public int NumOfMaxNow { get; set; } = 0;

        public Stone(string name, string color) : base(name)
        {
            Color = color;
        }
    }
}