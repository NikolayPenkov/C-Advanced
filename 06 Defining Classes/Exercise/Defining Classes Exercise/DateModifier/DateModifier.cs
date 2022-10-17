using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public static class DateModifier
    {
        public static int DateDifference(string startDate, string endDate)
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime end = DateTime.Parse(endDate);

            TimeSpan diff = start - end;

            return Math.Abs(diff.Days);
        }
        //DateTime startDate = DateTime.Parse(start)
    }
}
