using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{ 
        
    public class EmpFullOrPartTime
    {
        int Is_Full_Time = 2;
        int IS_Part_Time = 1;                 // Taking Variables 
        int Is_Absent = 0;
        const int Emp_Rate_Per_Hrs = 20;
        int Emp_Hrs = 0;

        // Creating Instance of Random Class...
        Random random =new Random();

        public void empDailywage()
        {
            int CheckEmp = random.Next(0, 3);
            Console.WriteLine("\nResult :- ");

            // Define if-else To check Part/Full Time..
            if (CheckEmp == Is_Full_Time)
            {
                Console.WriteLine("Today Employee have Worked  Full Time ");
                Emp_Hrs = 8;
            }
            else if(CheckEmp == IS_Part_Time)
            {
                Console.WriteLine("Today Employee have worked Part time ");
                Emp_Hrs = 4;
            }
            else
            {
                Console.WriteLine("Employee was Absent Today");
                Emp_Hrs = 0;
            }

            // Calculate Employee Daily Wage
            int empDailyWage = Emp_Hrs * Emp_Rate_Per_Hrs;
            Console.WriteLine("Employee Daily Wage are : {0}",empDailyWage);

        }
    }
}
