using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Telephony
{
    internal class StationaryPhone : ICallable
    {
        public void Calling(string number)
        {
            bool value = false;
            foreach (var item in number)
            {
                if (item > 57 || item < 48)
                {
                    Console.WriteLine("Invalid number!");
                    value = true;
                }
            }
            if (!value) { Console.WriteLine($"Dialing... {number}"); }
        }
    }
}
