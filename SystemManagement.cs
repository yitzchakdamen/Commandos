using Commandos.Interface;

namespace Commandos
{
    class SystemManagement
    {
        public List<ISoldier> ListSoldiers;
        public SystemManagement(List<ISoldier> listSoldiers)
        {
            ListSoldiers = listSoldiers;   
        }
    }

}