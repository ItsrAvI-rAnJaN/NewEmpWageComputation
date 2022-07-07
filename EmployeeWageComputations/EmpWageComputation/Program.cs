using System;

namespace EmpWageComputation
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t############################################################");
            Console.WriteLine("\t\t\t\t\tWELCOME TO EMPLOYEE WAGE COMPUTATIONS PROGRAM");
            Console.WriteLine("\t\t\t\t#############################################################");

            // Creating object/Instance of class CheckEmpAttendance..
            CheckEmpAttendance objAttendance =new CheckEmpAttendance();
            objAttendance.empAttendance();
            Console.ReadKey();
        }
    }
}