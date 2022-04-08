using ConsoleApp1.Classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeniorCooker seniorCooker = new SeniorCooker("Vasia", new MorningShift(5,12,9,10,new IceCream()),83.1f);
            Console.WriteLine(seniorCooker);
            Console.WriteLine();
            Cooker cooker = new Cooker("Petr",new EveningShift(12,20,15,16,new Potatos()), 43.5f);
            Console.WriteLine(cooker);
        }
    }
}
