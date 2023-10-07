using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                employees[i] = new Employee(input[0], double.Parse(input[1]), input[2]);
            }
            employees = employees.OrderByDescending(employee => employee.Salary).ToArray();
            Console.WriteLine($"Highest Average Salary: {employees[0].Department}");
            foreach (var employee in employees)
            {
                if (employee.Department == employees[0].Department) employee.Print();
            }
        }
    }
}
