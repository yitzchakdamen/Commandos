using System.Reflection.Metadata.Ecma335;

namespace Commandos.Interface
{
    interface ICommando : IWalk, IAttack, IHide
    {
        string Name { set; }
        string CodeName { get; set; }
        List<string> Tools { get; set; }
        string GetName(int Renk);
    }

    interface IWalk
    {
        void Walk();
    }

    interface IAttack
    {
        void Attak();

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

    interface IAirCommando : ICommando, IParachuting
    {

    }

    interface ISeaCommando : ICommando, ISwimming
    {

    }

}
