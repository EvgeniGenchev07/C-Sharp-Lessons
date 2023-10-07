using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_human
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Human person1 = new Human(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Human person2 = new Human(Console.ReadLine(),int.Parse(Console.ReadLine()));

            
            person1.IntroduceYourSelf();
            person2.IntroduceYourSelf();
        }
    }
}
