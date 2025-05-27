namespace Commandos.Interface
{
    interface ICommando : IWalk, IAttack, IHide
    {
        string Name { get; set; }
        string CodeName { get; set; }
        List<string> Tools { get; set; }
    }

    interface IWalk
    {
        public void Walk();
    }

    interface IAttack
    {
        public void Attak();

    }

    interface IHide
    {
        public void Hide();
    }

    interface IWeapon
    {
        public string Name { get; set; }
        public string manufacturer { get; set; }
        public int numOfBalls { get; set; }
    } 
}







 
