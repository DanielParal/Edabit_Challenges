using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultProject.OverTime
{
    public class OvertTime
    {
        public static string CalculateOverTime(double[] arr)
        {
            double startHour = arr[0];
            double endHour = arr[1];
            double hourlyRate = arr[2];
            double multiplierRate = arr[3];

            double overTimeHours = GetOverTimeHours(startHour, endHour) > 0 ? GetOverTimeHours(startHour, endHour) : 0;
            double normalWorkingHours = GetNormalWorkingHours(startHour, endHour);

            double salary = (normalWorkingHours * hourlyRate) + (overTimeHours * hourlyRate * multiplierRate);

            return "$" + salary.ToString("0.00");
        }

        public static double GetOverTimeHours(double startHour, double endHour)
        {
            if (GetEndWorkingHour() > startHour)
                return endHour - GetEndWorkingHour();

            return endHour - startHour;
        }

        public static double GetNormalWorkingHours(double startHour, double endHour)
        {
            double workingHours = GetRealEndHour(endHour) - startHour;

            if (workingHours < 0)
                return 0;

            return workingHours;
        }

        public static double GetRealEndHour(double endHour)
        {
            if (endHour > GetEndWorkingHour())
                return GetEndWorkingHour();

            return endHour;
        }

        private static double GetEndWorkingHour()
        {
            return 17;
        }
    }
}
