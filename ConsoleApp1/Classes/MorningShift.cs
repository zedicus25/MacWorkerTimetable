using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1.Classes
{
    internal class MorningShift : IShift
    {
        public IFood Food { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }
        public DateTime StartBreakHour { get; set; }
        public DateTime EndBreakHour { get; set; }
        public MorningShift() : this(6,12,9,10,new IceCream())
        {
        }
        public MorningShift(int startHour, int endHour, int startBreakHour, int endBreakHour, IFood food)
        {
            DateTime now = DateTime.Now;
            StartHour = new DateTime(now.Year, now.Month, now.Day, startHour, 0, 0);
            EndHour = new DateTime(now.Year, now.Month, now.Day, endHour, 0, 0);
            StartBreakHour = new DateTime(now.Year, now.Month, now.Day, startBreakHour, 0, 0);
            EndBreakHour = new DateTime(now.Year, now.Month, now.Day, endBreakHour, 0, 0);
            Food = food;
        }
        public int CalculateWorkHours()
        {
            int result = 0;
            result = EndHour.Subtract(StartHour).Hours;
            result -= EndBreakHour.Subtract(StartBreakHour).Hours;
            return result;
        }

        public DateTime GetStart()
        {
            return StartHour;
        }

        public DateTime GetEnd()
        {
            return EndHour;
        }

        public DateTime GetBreakStart()
        {
            return StartBreakHour;
        }

        public DateTime GetBreakEnd()
        {
            return EndBreakHour;
        }

        public override string ToString()
        {
            return String.Format("Morning shift at {0}", Food.Cook());
        }
    }
}
