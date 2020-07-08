using System;
using System.Collections.Generic;
using System.Text;

namespace P05DateModifier
{
    public static class DateModifier
    {
        public static double GetDiffInDaysBetweenTwoDates(string firstDate, string secondDate)
        {
            DateTime startDate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(secondDate);

            var days = (startDate - endDate).TotalDays;

            var absoluteDays = Math.Abs(days);

            return absoluteDays;
        }
    }
}
