using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Order_by_Age
{
    internal class People
    {
        string name;
        string id;
        string age;
        public People(string name, string id, string age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
        public void output()
        {
            Console.WriteLine($"{name} with ID: {id} is {age} years old.");
        }
    }
}
