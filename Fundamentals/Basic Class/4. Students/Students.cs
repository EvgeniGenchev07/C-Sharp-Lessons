using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Students
{
    internal class Students
    {
        private string firstName;
        private string lastName;
        private double grade;
        public Students(string firstName, string lastName, double grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }
        
        public void Output()
        {
            Console.WriteLine($"{firstName} {lastName}: {grade:f2}");
        }
    }
}
