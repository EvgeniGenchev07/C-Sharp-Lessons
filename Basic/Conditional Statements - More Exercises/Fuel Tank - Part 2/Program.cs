using System;

namespace Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());    
            string c = Console.ReadLine();
            double d = 0;
            if (a == "Gas" & c == "Yes")
            {
                 d = 0.85 * b;
            } 
            else if (a == "Gas" & c == "No")
            {
                 d = 0.93 * b;
                
            }
            else if (a == "Gasoline" & c == "No")
            {
               d = 2.22 * b;
                
            }
            else if (a == "Gasoline" & c == "Yes")
            {
                 d = 2.04 * b;
            }
            else if (a == "Diesel" & c == "Yes")
            {
               d = 2.21 * b;
            }
            else if (a == "Diesel" & c == "No")
            {
                 d = 2.33 * b;
            }
            if (b<= 25 & b>= 20)
            {
                double f = d - d * 0.01 * 8;
                Console.WriteLine($"{f:f2} lv.");
            }
            else if (b > 25)
            {
                double f = d - d * 0.01 * 10;
                Console.WriteLine($"{f:f2} lv.");
            }
            else if (b < 20)
            {
                Console.WriteLine($"{d:f2} lv."); 
            }
        }
    }
}
