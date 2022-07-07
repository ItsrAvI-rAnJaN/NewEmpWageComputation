using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public  class EmpDailyWage
    {
        int Is_present = 0;
        int Is_Absent = 1;                                  //Taking Variables 
        int Emp_Hrs;
        const  int Emp_Rate_Per_Hrs= 20;

        // Creating instance of Random Class 
        Random random = new Random();

        // Define Method to Calculate Employee DWage..
        public void calcEmpDailyWage()
        {
            int CheckAttendance = random.Next(0, 2);

            Console.WriteLine("\nResult :- " +
                "");
            if (CheckAttendance == Is_present)
            {
                Console.WriteLine("Employee is Present");
                Emp_Hrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Emp_Hrs = 0;
            }

            //CalCulate Daily Employee Wage..
            int dailyEmpWage = Emp_Hrs * Emp_Rate_Per_Hrs;
            Console.WriteLine("Employee Daily Wage are : {0}", dailyEmpWage);
            
        }
        

        

    }
}
