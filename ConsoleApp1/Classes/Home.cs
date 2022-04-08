using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    internal class Home : IFood
    {
        public string Cook()
        {
            return "Home";
        }
    }
}
