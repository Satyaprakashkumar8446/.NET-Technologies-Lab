using System;

namespace EmployeePayrollSystem
{
    // Interface
    interface IPayroll
    {
        double CalculateSalary();
        void DisplayEmployee();
    }

    // Base Class
    class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        public double BasicSalary;

        public void GetEmployeeDetails()
        {
            Console.Write("Enter Employee ID : ");
            EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name : ");
            EmployeeName = Console.ReadLine();

            Console.Write("Enter Basic Salary : ");
            BasicSalary = Convert.ToDouble(Console.ReadLine());
        }
    }

    // Full-Time Employee Class
    class FullTimeEmployee : Employee, IPayroll
    {
        public override string ToString()
        {
            return "Full-Time Employee";
        }

        public double CalculateSalary()
        {
            double hra = BasicSalary * 0.20;
            double da = BasicSalary * 0.15;
            return BasicSalary + hra + da;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine("\n========== PAYROLL ==========");
            Console.WriteLine("Employee Type : " + this);
            Console.WriteLine("Employee ID   : " + EmployeeId);
            Console.WriteLine("Employee Name : " + EmployeeName);
            Console.WriteLine("Basic Salary  : " + BasicSalary);
            Console.WriteLine("Net Salary    : " + CalculateSalary());
        }
    }

    // Part-Time Employee Class
    class PartTimeEmployee : Employee, IPayroll
    {
        public int WorkingHours;
        public double RatePerHour;

        public void GetPartTimeDetails()
        {
            Console.Write("Enter Working Hours : ");
            WorkingHours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rate Per Hour : ");
            RatePerHour = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Part-Time Employee";
        }

        public double CalculateSalary()
        {
            return WorkingHours * RatePerHour;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine("\n========== PAYROLL ==========");
            Console.WriteLine("Employee Type : " + this);
            Console.WriteLine("Employee ID   : " + EmployeeId);
            Console.WriteLine("Employee Name : " + EmployeeName);
            Console.WriteLine("Working Hours : " + WorkingHours);
            Console.WriteLine("Rate Per Hour : " + RatePerHour);
            Console.WriteLine("Net Salary    : " + CalculateSalary());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Employee Payroll System =====");
            Console.WriteLine("1. Full-Time Employee");
            Console.WriteLine("2. Part-Time Employee");

            Console.Write("Select Employee Type : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            IPayroll payroll;

            if (choice == 1)
            {
                FullTimeEmployee emp = new FullTimeEmployee();
                emp.GetEmployeeDetails();

                payroll = emp;      // Polymorphism
            }
            else if (choice == 2)
            {
                PartTimeEmployee emp = new PartTimeEmployee();
                emp.GetEmployeeDetails();
                emp.GetPartTimeDetails();

                payroll = emp;      // Polymorphism
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
                return;
            }

            payroll.DisplayEmployee();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
