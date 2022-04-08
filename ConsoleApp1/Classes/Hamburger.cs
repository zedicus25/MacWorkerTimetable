using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    internal class Hamburger : IFood
    {
        public string Cook()
        {
            return "Hamburgers";
        }
    }
}
