using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5.Telephony
{
    internal class Smartphone : ICallable,IBrowsable
    {
        public void Calling(string number)
        {
            bool value = false;
            foreach (var item in number)
            {
                if (item>57||item<48)
                {
                    Console.WriteLine("Invalid number!");
                    value = true;
                }
            }
            if(!value) { Console.WriteLine($"Calling... {number}"); }
        }
        public void Browsing(string url)
        {
            bool value = false;
            foreach (var item in url)
            {
                if (item <= 57 && item >= 48)
                {
                    Console.WriteLine("Invalid url!");
                    value = true;
                    break;
                }
            }
            if (!value) { Console.WriteLine($"Browsing: {url}!"); }
        }
    }
}
