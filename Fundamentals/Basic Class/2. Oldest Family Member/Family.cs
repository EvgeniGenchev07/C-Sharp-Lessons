using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Oldest_Family_Member
{
    internal class Family
    {
        string name;
        int age;
        public Family(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int Age
        {
            get { return age; } set {  age = value; }
        }
        public void Print()
        {
            Console.WriteLine(name+" "+age);
        }
    }
}
