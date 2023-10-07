using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Define_an_Interface_IPerson
{
    internal class Citizen : IPerson

    {
        private string name;
        private int age;
        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
    }
}
