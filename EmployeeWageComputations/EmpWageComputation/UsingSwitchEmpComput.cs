using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class UsingSwitchEmpComput
    {
        const int Is_Full_Time = 2;
        const int Is_Part_Time = 1;
        const int Is_Absent = 0;
        const int Rate_Per_Hrs = 20;
        int EmpHrs = 0;
        
        Random random = new Random();

        // Creating Method for Employee Wage Computation...
        public void EmpWageComputation()
        {
            int CheckEmp = random.Next(0, 3);
            Console.WriteLine("\nEmployee Daily Wage Computations :- ");

            switch (CheckEmp)
            {
                case Is_Full_Time:
                    Console.WriteLine("Today Employee have  Worked Full Time ");
                    EmpHrs = 8;
                    break;
                case Is_Part_Time:
                    Console.WriteLine("Today Employee have  Worked Half Time ");
                    EmpHrs=4;
                    break;

                default:
                    Console.WriteLine("Today Employee Was Absent");
                    break;

            }
            int empWage = EmpHrs * Rate_Per_Hrs;
            Console.WriteLine("Employee Daily Wage : {0}",empWage);

        }
    }
}
