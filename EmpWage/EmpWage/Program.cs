using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int checkVariable = random.Next(2);

            if (checkVariable == IS_FULL_TIME)
                Console.WriteLine("Employee is Present.");
            else
                Console.WriteLine("Employee is Absent.");
        }
    }
}
