using System;

namespace Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double d = 0;
            double sum = 0;
            double sum2 = 0;
            int o = 0;
            while (true)
            {
                
                string b = Console.ReadLine();
                if (b == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {(sum2/o):f2}.");
                    break;
                }
                for (int i = 1; i <= a; i++)
                {
                    d = double.Parse(Console.ReadLine());
                    o++;
                    sum += d;
                    sum2 += d;
                }
                Console.WriteLine($"{b} - {(sum/a):f2}.");
                sum = 0;
            }
        }
    }
}
