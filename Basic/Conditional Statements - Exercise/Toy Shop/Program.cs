using System;

namespace Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double holiday = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int car = int.Parse(Console.ReadLine());
            double sPuzzels = puzzels * 2.60;
            double sDolls = dolls * 3;
            double sBear = bear * 4.10;
            double sMinions = minions * 8.20;
            double sCar = car * 2;
            double sum = 0;
            int toys = puzzels + dolls + bear + car + minions;
            if (toys >= 50)
            {
                sum = (sPuzzels + sDolls + sBear + sMinions + sCar) - (sPuzzels + sDolls + sBear + sMinions + sCar) * 25 * 0.01;

            }
            else
            {
                sum = sPuzzels + sDolls + sBear + sMinions + sCar;
            }
            double rSum = sum - sum * 10 * 0.01;
            if (rSum >= holiday)
            {
                double tSum = rSum - holiday;
                Console.WriteLine($"Yes! {tSum:f2} lv left.");
            }
            else
            {
                double nHoliday = holiday - rSum;
                Console.WriteLine($"Not enough money! {nHoliday:f2} lv needed.");
            }

        }
    }
}
