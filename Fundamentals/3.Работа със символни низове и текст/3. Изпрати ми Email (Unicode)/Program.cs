using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Изпрати_ми_Email__Unicode_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            int p = email.IndexOf('@');
            int sum = 0;
            for (int i = 0; i < p; i++) sum += email[i];
            for (int i = p + 1; i < email.Length; i++) sum -= email[i];
            if (p - (email.Length - p - 1) >= 0) Console.WriteLine("Call her!");
            else Console.WriteLine("She is not the one.");
        }
    }
}
