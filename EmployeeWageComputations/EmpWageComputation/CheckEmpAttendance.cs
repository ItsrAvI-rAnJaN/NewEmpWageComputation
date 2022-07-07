using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class CheckEmpAttendance
    {
        int Is_Present = 1;
        int Is_Absent = 0;
        Random random = new Random();
        
        // Define Method to Check Employee Attendance 
        public void empAttendance()
        {
           int  CheckAttendance = random.Next(0, 2);
           Console.WriteLine("Employee Attendance :-");

            //define logic If-else to check present or Absent 
            if (CheckAttendance == Is_Absent)
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }

        }
    }
}
