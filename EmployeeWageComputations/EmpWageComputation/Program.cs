using System;

namespace EmpWageComputation
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t############################################################");
            Console.WriteLine("\t\t\t\t\tWELCOME TO EMPLOYEE WAGE COMPUTATIONS PROGRAM");
            Console.WriteLine("\t\t\t\t#############################################################\n");
            Console.WriteLine("Press 0 to 'Exit'");
            Console.WriteLine("Press 1 to Check Employee Attendance");
            Console.WriteLine("Press 2 to Calculate Employee Daily Wage");
            Console.WriteLine("Press 3 to Check Employee Part or Full Time Working & Also Calculate Wages ");
            Console.WriteLine("Press 4 to Check Employee Daily Wage Compuntations Using Switch Case");
            Console.Write("\nEnter Your Choice : ");
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    // Creating object/Instance of class CheckEmpAttendance..
                    CheckEmpAttendance objAttendance = new CheckEmpAttendance();

                    //Calling The Method/Function..
                    objAttendance.empAttendance();
                    break;

                case 2:
                    EmpDailyWage objEmpWage = new EmpDailyWage();
                    objEmpWage.calcEmpDailyWage();
                    break;

                case 3:
                    EmpFullOrPartTime objPartorFullTimeWages = new EmpFullOrPartTime();
                    objPartorFullTimeWages.empDailywage();
                    break;
                case 4:
                    UsingSwitchEmpComput objEmpDailyWage =new UsingSwitchEmpComput();
                    objEmpDailyWage.EmpWageComputation();
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("\nPlease Enter Correct Choice");
                    break;

            }
            
            // to Hold Input Terminal..
            Console.ReadKey();

        }
    }
}