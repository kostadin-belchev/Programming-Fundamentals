using System;

namespace _03_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employeeID = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());

            var digits = employeeID.ToString().Length;
            var eID = "Employee ID: ";

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            // 19/09/2017 - Now using Padleft instead of switch cases.
            Console.WriteLine("Employee ID: {0}",employeeID.PadLeft(8,'0'));
           
            Console.WriteLine("Salary: {0:f2}", salary);
        }
    }
}
