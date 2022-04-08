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
        public override string ToString()
        {
            string[] str = Shift.ToString().Split(' ');
            if (str[str.Length-1].Equals("Home"))
                return "You not work today";
            return String.Format("You work SeniorCooker on {0} from {1} to {2}.\nYou have break from {3} to {4} and your " +
                "hourly rate is {5}\nIf you will work all hours you get {6}", Shift.ToString(), Shift.GetStart().Hour, Shift.GetEnd().Hour, Shift.GetBreakStart().Hour
                ,Shift.GetBreakEnd().Hour, HourlyRate, CalculateSalary());
        }
    }
}
