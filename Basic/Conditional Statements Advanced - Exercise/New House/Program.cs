using System;

namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double sum = 0;
            
                if (a == "Roses")
                {
                    sum = b * 5.00;
                    if (b > 80)
                    {
                        sum = sum - sum * 0.1;
                    }
                  
                }
                else if (a == "Dahlias")
                {
                    sum = b * 3.80;
                    if (b > 90)
                    {
                        sum = sum - sum * 0.15;
                    }
                  
                }
                else if (a == "Tulips")
                {
                    sum = b * 2.80;
                    if (b > 80)
                    {
                        sum = sum - sum * 0.15;
                    }
                   
                }
                else if (a == "Narcissus")
                {
                    sum = b * 3.00;
                    if (b < 120)
                    {
                        sum = sum + sum * 0.01 * 15;
                    }
        
                    
                }
                else if (a == "Gladiolus")
                {
                    sum = b * 2.50;
                    if (b < 80)
                    {
                        sum = sum + sum * 0.2;
                    }
                   
                }
            
            if (sum <= c)
            {
                double d = c - sum;
                Console.WriteLine($"Hey, you have a great garden with {b} {a} and {d:f2} leva left.");
            }
            else
            {
                double d = sum - c;
                Console.WriteLine($"Not enough money, you need {d:f2} leva more.");
            }

        }
    }
}
