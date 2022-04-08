using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    internal class Potatos : IFood
    {
        public void Cook()
        {
            System.Console.WriteLine("You cook potatos");
        }
    }
}
