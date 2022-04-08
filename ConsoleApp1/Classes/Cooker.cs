using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1.Classes
{
    internal class Cooker : IWorker
    {
        public IShift Shift { get; set; }
        public  string Name { get; set; }
        public float HourlyRate { get; set; }
        public Cooker() : this("", new MorningShift(), 50.5f)
        {
        }
        public Cooker(string name, IShift shift, float hourlyRate)
        {
            Name = name;
            Shift = shift;
            HourlyRate = hourlyRate;
        }
        public float CalculateSalary()
        {
            float salary = 0;
            salary = HourlyRate * Shift.CalculateWorkHours();
            return salary;
        }
    }
}
