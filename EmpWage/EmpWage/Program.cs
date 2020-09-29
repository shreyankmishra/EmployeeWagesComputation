using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PRESENT = 1;
            int dailyWage, dailyHours;

            Random random = new Random();

            int checkValue = random.Next(2);

            if (checkValue == IS_PRESENT)
            {
                dailyHours = 8;
            }
            else
            {
                dailyHours = 0;
            }

            dailyWage = dailyHours * 20;

            Console.WriteLine("Daily wage is : " + dailyWage);
        }
    }
}
