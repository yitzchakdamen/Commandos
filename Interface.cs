using Commandos.EnemyArea;

namespace Commandos.Interface
{
    interface ISoldier : IWalk, IAttack, IHide
    {
        string Name { set; }
        string CodeName { get; set; }
        List<string> Tools { get; }
        string Status { get; set; }
        string? SayName(string Renk);
    }

    interface IWalk
    {
        void Walk();
    }

    interface IAttack
    {
        void Attak(Enemy e);

    }

    interface IHide
    {
        void Hide();
    }

    interface IParachuting
    {
        void Parachuting();
    }

    interface ISwimming
    {
        void Swimming();
    }


    interface IWeapon
    {
        string Name { get; set; }
        string Manufacturer { get; set; }
        int NumOfBullets { get; set; }
        void Shoot();
    }

    interface IAirCommando : ISoldier, IParachuting
    {

    }

    interface ISeaCommando : ISoldier, ISwimming
    {

    }

}
