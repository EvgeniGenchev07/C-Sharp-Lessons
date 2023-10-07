using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBrowsable smartphone = new Smartphone();
            ICallable phone = new Smartphone();
            ICallable stationaryPhone = new StationaryPhone();
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();
            foreach (string number in numbers)
            {
                if (number.Length < 10)
                {
                    stationaryPhone.Calling(number);
                }
                else phone.Calling(number);
            }
            foreach (string url in urls)
            {
                smartphone.Browsing(url);
            }
        }
    }
}
