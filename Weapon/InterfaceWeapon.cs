namespace Commandos.WeaponArea
{
    interface IWeapon
    {
        string Name { get; set; }
    }

    // interface IFirearms : IWeapon
    // {
    //     string Manufacturer { get; set; }
    // }

    interface IShootable
    {
        public int NumOfBullets { get; set; }
        public void Shoot();
        public void AddBullets();
    }

    interface IBreakable
    {
        public bool Status { get; set; }
        public int NumOfMaxHits { get; set; }
        public int NumOfMaxNow { get; set; }
    }
}