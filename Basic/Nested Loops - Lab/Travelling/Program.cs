using System;

namespace Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                double sum = 0;
                string a = Console.ReadLine();
                if (a == "End")
                {
                    return;
                }
                else
                {
                    double b = double.Parse(Console.ReadLine());
                    
                    while(true)                  
                    {
                         double l = double.Parse(Console.ReadLine());
                        sum += l;
                        if (sum >= b)
                        {
                            Console.WriteLine($"Going to {a}!");
                            break;
                        }
                    }
                }
            }
        }
    }
}
