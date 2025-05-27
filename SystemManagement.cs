using Commandos.Interface;

namespace Commandos
{
    class SystemManagement
    {
        public List<ICommando> ListSoldiers = Fors.ListSoldiers;
        public SystemManagement(List<ICommando> ListSoldiers)
        {
            foreach (ICommando Soldiers in ListSoldiers)
            {
                Fors.AadToList(Soldiers);
                
            }
        }
    
    }

}