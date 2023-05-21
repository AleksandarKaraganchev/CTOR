using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazlikaVDniMejdu2Dati
{
    internal class DateModifier
    {
        public static int CalculateDateDifference(string firstDate, string secondDate)
        {
            DateTime date1 = DateTime.Parse(firstDate); //DateTime is for time, while TimeSpan represents a time interval
            DateTime date2 = DateTime.Parse(secondDate);
            TimeSpan difference = date2 - date1;
            return Math.Abs(difference.Days);
        }
    }
}
