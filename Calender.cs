using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Calender
    {

        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public void PrintWeekdays()
        {
            foreach(DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            {
                if (day <= DaysOfWeek.Friday) {
                    Console.WriteLine(day);
                }
            }
        }

    }
}
