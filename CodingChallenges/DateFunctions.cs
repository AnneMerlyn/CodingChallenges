using System;
namespace CodingChallenges
{
    public static class DateFunctions
    {
        public static int DaysLeft(DateTime fromDate, DateTime toDate)
        {
            int days = (int)toDate.Subtract(fromDate).TotalDays;

            if (days < 0)
            {
                days = 0;
            }

            return days;
        }
    }
}

