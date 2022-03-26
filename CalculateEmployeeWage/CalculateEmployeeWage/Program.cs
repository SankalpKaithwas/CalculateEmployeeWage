using System;
using System.Collections;
using System.Collections.Generic;

namespace CalculateEmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC8 Employees monthly wage using Function for Multiple companies
            Console.WriteLine("Welcome to Employee Wage Computation!");
            Console.WriteLine();
            EmployeeWageComputaion wage = new EmployeeWageComputaion();
            wage.AddCompany("TATA", 20, 8, 4, 100, 20);
            wage.AddCompany("Mahindra", 30, 8, 4, 100, 40);
            wage.AddCompany("Microsoft", 100, 8, 4, 100, 30);

            // UC12 Employee monthly wage using ArrayList
            ArrayList companyWages = new ArrayList();
            companyWages.Add(wage.CalculateWage("Microsoft"));
            companyWages.Add(wage.CalculateWage("Tata"));
            companyWages.Add(wage.CalculateWage("Mahindra"));

            foreach (var item in companyWages)
            {
                Console.WriteLine(item);
            }

        }
    }
}
