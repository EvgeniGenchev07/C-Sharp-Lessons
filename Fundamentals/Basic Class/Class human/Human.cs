using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_human
{
    internal class Human
    {
        private string name;
        private int age;

        
        public string Name
        {
            
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; } 
            set { age = value; }
        }
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        public void IntroduceYourSelf()
        {

            Console.WriteLine($"I am {name} and I am {age} years old. ");
        }
    }
}
