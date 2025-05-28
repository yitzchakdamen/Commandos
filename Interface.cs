using Commandos.EnemyArea;

namespace Commandos.Interface
{
    public interface ISoldier : IWalk, IAttack, IHide
    {
        string Name { set; }
        string CodeName { get; set; }
        List<string> Tools { get; }
        string Status { get; set; }
        string? SayName(string Renk);
    }

    public interface IWalk
    {
        void Walk();
    }

    public interface IAttack
    {
        void Attak(Enemy e);

    }

    public interface IHide
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

    interface IAirCommando : ISoldier, IParachuting
    {

    }

    interface ISeaCommando : ISoldier, ISwimming
    {

    }

}
