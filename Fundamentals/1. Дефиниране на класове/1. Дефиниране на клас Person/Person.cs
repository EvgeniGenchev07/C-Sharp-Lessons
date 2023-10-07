using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Дефиниране_на_клас_Person
{
    internal class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"I am {name} and I am {age} years old.");
        }
    }
}
