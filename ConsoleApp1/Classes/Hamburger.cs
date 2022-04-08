using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    internal class Hamburger : IFood
    {
        public void Cook()
        {
            System.Console.WriteLine("You cook hamburgers");
        }
    }
}
