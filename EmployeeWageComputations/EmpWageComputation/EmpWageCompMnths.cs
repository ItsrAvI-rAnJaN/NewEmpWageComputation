using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpWageCompMnths
    {
        public const int Is_Full_Time = 1;
        public const int Is_Absent = 0;
        public const int Is_Part_Time = 2;
        public const int Emp_Rate_Per_hrs = 20;
        public const int Max_Num_Of_Wrkng_Days = 20;
        public const int Max_Hrs_In_Mnths = 100;
        int EmpHrs = 0;
        int Total_Wrkng_Days = 0;
        int TotalHrs=0;
        Random random = new Random();
        
        public void EmpWageComputation()
        {
            while (TotalHrs < Max_Hrs_In_Mnths && Total_Wrkng_Days < Max_Num_Of_Wrkng_Days)
            {
                Total_Wrkng_Days++;
                int CheckEmp = random.Next(0, 3);
                switch (CheckEmp)
                {
                    case Is_Full_Time:
                        Console.WriteLine("\nDay{0}: Today Employee have  Worked Full Time ", Total_Wrkng_Days);
                        EmpHrs = 8;
                        break;
                    case Is_Part_Time:
                        Console.WriteLine("\nDay{0}: Today Employee have  Worked Part Time ", Total_Wrkng_Days);
                        EmpHrs = 4;
                        break;

                    default:
                        Console.WriteLine("\nDay{0}: Today Employee Was Absent", Total_Wrkng_Days);
                        EmpHrs = 0;
                        break;

                }
                TotalHrs += EmpHrs;
                Console.WriteLine("Employee had Work for {0} hrs.", EmpHrs);
                if (TotalHrs == Max_Hrs_In_Mnths)
                {
                    Console.WriteLine("\nTotal Working Hours in this months has reached {0}hrs",TotalHrs);
                }
                if(Total_Wrkng_Days == Max_Num_Of_Wrkng_Days)
                {
                    Console.WriteLine("\nTotal Working Days in this months has reached {0}",Total_Wrkng_Days);
                }
            }
            int TotalWage = TotalHrs * Emp_Rate_Per_hrs;
            Console.WriteLine("\n*****************************************************************************");
            Console.WriteLine("Employee Management :-");
            Console.WriteLine("Total Hours in a Month : {0}",TotalHrs);
            Console.WriteLine("Total Days in a Month  : {0}", Total_Wrkng_Days);
            Console.WriteLine("Total Wages in a Month : {0}",TotalWage);
        }
    }
}
