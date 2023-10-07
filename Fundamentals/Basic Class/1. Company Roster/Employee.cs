using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Company_Roster
{
    internal class Employee
    {
        string name;
        double salary;
        string department;
        public Employee(string name, double salary, string department)
        {
            this.name = name;
            this.salary = salary;
            this.department = department;
        }

        public double Salary
        {
            get { return salary; } set {  salary = value; }
        }
        public string Department
        {
            get { return department; } set {  department = value; }
        }
        public void Print()
        {
            Console.WriteLine($"{name} {salary:f2}");
        }
    }
}
