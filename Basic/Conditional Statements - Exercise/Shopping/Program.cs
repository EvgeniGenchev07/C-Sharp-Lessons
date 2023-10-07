using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double buy = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double sGpu = 250 * gpu;
            double sCpu = sGpu * 35 * 0.01 * cpu;
            double sRam = sGpu * 10 * 0.01 * ram;
            if (gpu > cpu)
            {
                total = (sGpu + sCpu + sRam) - (sGpu + sCpu + sRam) * 15 * 0.01;
            }
            else
            {
                total = sGpu + sCpu + sRam;
            }
            if (buy < total)
            {
                double aBuy = total - buy;
                Console.WriteLine($"Not enough money! You need {aBuy:f2} leva more!");
            }
            else
            {
                double bBuy = buy - total;
                Console.WriteLine($"You have {bBuy:f2} leva left!");
            }





        }
    }
}
