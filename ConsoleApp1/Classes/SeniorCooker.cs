using ConsoleApp1.Interfaces;
using System;


namespace ConsoleApp1.Classes
{
    internal class SeniorCooker : IWorker
    {
        public IShift Shift { get; set; }
        public string Name { get; set; }
        public float HourlyRate { get; set; }
        public SeniorCooker() : this("", new MorningShift(), 100.5f)
        {
        }
        public SeniorCooker(string name, IShift shift, float hourlyRate)
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
