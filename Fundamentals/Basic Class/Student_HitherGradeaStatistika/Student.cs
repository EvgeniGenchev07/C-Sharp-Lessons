using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Student_HitherGradeaStatistika
{
    internal class Student
    {
        private string firstName;
        private string lastName;
        private double grade;
        List<string> firstNames=new List<string>();
        List<string> lastNames=new List<string>();
        List<double> grades= new List<double>();
        public void Names(string firstName,string lastName)
        {
            firstNames.Add(firstName);
            lastNames.Add(lastName);
        }
        public void Grades(double grade)
        {
            grades.Add(grade);
        }
        public void HitherGrade(double BestGrade)
        {
            byte index=(byte)grades.IndexOf(BestGrade);
            firstName = firstNames[index];
            lastName = lastNames[index];
            grade = grades[index];
        }
        public void output()
        {
            Console.WriteLine($"{firstName} {lastName} {grade}");
        }
    }
}
