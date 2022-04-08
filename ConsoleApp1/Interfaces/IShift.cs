
using System;

namespace ConsoleApp1.Interfaces
{
    internal interface IShift
    {
        int CalculateWorkHours();
        DateTime GetStart();
        DateTime GetEnd();
        DateTime GetBreakStart();
        DateTime GetBreakEnd();
    }
}
