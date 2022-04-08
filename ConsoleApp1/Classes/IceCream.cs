using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    internal class IceCream : IFood
    {
        public void Cook()
        {
            System.Console.WriteLine("You cook a ice cream");
        }
    }
}
