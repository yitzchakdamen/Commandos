using Commandos.Interface;

namespace Commandos
{
    class Soldier : ISoldier
    {

        public string Name { protected get; set; }
        public string CodeName { get; set; }
        public List<string> Tools { get; }
        public string Status { get; set; }

        public Soldier(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            Tools = new() { "Hammer", "chisel", "rope", "bag", "water", "bottle" };
            Status = "standing comfortably";
        }

        public string? SayName(string Renk)
        {
            if (Renk == "GENERAL")
            {
                return Name;
            }
            else if (Renk == "COLONEL")
            {
                return CodeName;
            }
            Console.WriteLine($"The information is not accessible to the {Renk} rank.");
            return null;
        }

        public void Walk()
        {
            Status = "Walk";
            Print("Walk");   
        }

        public void Hide()
        {
            Status = "Hide";
            Print("Hide");   

        }

        public virtual void Attak()
        {
            Print("Attak");   
        }

        public void Print(string action)
        {
            Console.WriteLine($"the soldier - {CodeName} is {action}");
        }
    }
    
}