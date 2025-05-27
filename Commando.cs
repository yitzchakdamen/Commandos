using Commandos.Interface;

namespace Commandos
{
    class Commando : ICommando
    {

        public string Name { protected get; set; }
        public string CodeName { get; set; }
        public List<string> Tools { get; }
        public string Status = "standing comfortably";

        public Commando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            Tools = new() { "Hammer", "chisel", "rope", "bag", "water", "bottle" };
        }

        public string? GetName(string Renk)
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

        public void Attak()
        {
            Print("Attak");   
        }

        public void Print(string action)
        {
            Console.WriteLine($"the soldier - {CodeName} is {action}");
        }
    }
    
}