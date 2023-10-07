using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Увеличение_на_заплатата
{
    internal class Person
    {
        string firstName;
        string lastName;
        int age;
        double salary;
        public Person(string firstName,string lastName, int age, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
        public string FirstName
        {
            get { return firstName; }
            set 
            {
                if (value.Length < 3) throw new ArgumentException("First name cannot be less than 3 symbols");
                firstName = value;
            }
        }
        public string LastName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("First name cannot be less than 3 symbols");
                lastName = value;
            }
        }
        public int Age
        {
            get { return age; }
            set 
            {
                if (value <= 0) throw new ArgumentException("Age cannot be zero or negative integer");
                age = value;
            }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 460) throw new ArgumentException("Salary cannot be less than 460 leva");
                salary = value;
            }
        }
        public void BonusCount(double bonus)
        {
            if (Age < 30) bonus = 1+bonus / 2 / 100;
            else bonus /= 100;
            salary *= bonus;
        }
        public override string ToString()
        {
            return $"{firstName} {lastName} get {salary:f1} leva";
        }
    }
}
