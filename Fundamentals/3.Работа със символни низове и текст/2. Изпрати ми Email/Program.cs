using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Изпрати_ми_Email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            int p=email.IndexOf('@');
            if (p-(email.Length-p-1)>=0) Console.WriteLine("Call her!");
            else Console.WriteLine("She is not the one.");    
            

            

        }
    }
}
