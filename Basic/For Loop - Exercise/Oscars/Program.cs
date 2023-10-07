using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double point1 = double.Parse(Console.ReadLine());   
            int a = int.Parse(Console.ReadLine());
            double sum1 = 0;
            for (int i = 0; i < a; i++)
            {
                string b = Console.ReadLine();
                double d = double.Parse(Console.ReadLine());
                sum1 = (d * b.Length)/2;
                point1 += sum1;
                if (point1 >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {point1:f1}!");
                    break;
                }
            }
            
            if (point1 <1250.5)
            {
                double sum4 = 1250.5 - point1;
                Console.WriteLine($"Sorry, {actor} you need {sum4:f1} more!");
            }
        }
    }
}
