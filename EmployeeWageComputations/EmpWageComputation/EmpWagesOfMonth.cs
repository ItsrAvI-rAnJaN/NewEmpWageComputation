using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpWagesOfMonth
    {
        int Is_Full_Time = 1;
        int Is_Absent =0;
        int Is_Part_Time = 2;
        int Max_Days_InMnths = 20;
        int Emp_Rate_Per_Hrs = 20;
        int EmpHrs;
        int EmpDailyWage=0;
        int MnthWage;
        Random random = new Random();

        public void CalcEmpWagesOfMnths()
        {
            for(int i = 1; i <= Max_Days_InMnths; i++)
            {
                int CheckEmp=random.Next(0, 3);

                if (CheckEmp == Is_Full_Time)
                {
                    Console.WriteLine("Day {0}:Today Employee have Worked  Full Time ",i);
                    EmpHrs =8;
                }
                else if (CheckEmp == Is_Part_Time)
                {
                    Console.WriteLine("Day {0}:Today Employee have worked Part time ",i);
                    EmpHrs = 4;
                }
                else
                {
                    Console.WriteLine("Day {0}:Employee was Absent Today", i);
                    EmpHrs = 0;
                }
                EmpDailyWage = EmpHrs * Emp_Rate_Per_Hrs;
                MnthWage += EmpDailyWage;
                Console.WriteLine("Employee Wage : {0}",EmpDailyWage);
            }
            
            Console.WriteLine("\nEmployee Total Wage of A Months : {0}", MnthWage);



        }
    }
}
