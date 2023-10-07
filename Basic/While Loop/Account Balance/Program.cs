using System;

namespace Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0; 
            double d = 0;
            while (true)
            {
                string b = Console.ReadLine();
                
                if (b == "NoMoreMoney")
                {
                    break;
                }
                d = double.Parse(b);
                if (d<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {

                    Console.WriteLine($"Increase: {d:f2}");
                    sum = sum + d;
                }
                
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
