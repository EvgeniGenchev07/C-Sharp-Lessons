using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Person
{
    internal class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        protected string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { if (value > 15) { throw new ArgumentException("Ages must be possitive and less than 15"); } age = value; } }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
