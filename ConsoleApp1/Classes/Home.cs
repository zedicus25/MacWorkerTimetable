using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    internal class Home : IFood
    {
        public void Cook()
        {
            System.Console.WriteLine("You dont need work");
        }
    }
}
