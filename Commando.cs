using Commandos.Interface;

namespace Commandos
{
    class Commando : ICommando
    {

        public string Name {protected get; set; }
        public string CodeName { get; set; }
        public List<string> Tools { get; }

        public Commando(string name, string codeName, List<string> tools)
        {
            Name = name;
            CodeName = codeName;
            Tools = tools;
        }

        public string GetName(int Renk)
        {
            return "";
        }

        public void Walk()
        {
            Console.WriteLine($"the soldier - {CodeName} is Walk");
        }

        public void Hide()
        {
            Console.WriteLine($"the soldier - {CodeName} is Hide");
        }

        public void Attak()
        {
            Console.WriteLine($"the soldier - {CodeName} is Attak");
        }
        
    }
    
}