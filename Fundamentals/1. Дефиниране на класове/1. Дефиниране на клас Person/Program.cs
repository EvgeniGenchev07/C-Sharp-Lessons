using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Дефиниране_на_клас_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++) 
            {
                persons.Add(new Person(Console.ReadLine(), int.Parse(Console.ReadLine())));
                persons[i].IntroduceYourself();
            }
        }
    }
}
