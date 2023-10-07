using System;

namespace Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceFruit = double.Parse(Console.ReadLine());
            double priceVegetables = double.Parse(Console.ReadLine());
            int kgFruit = int.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());   
            double sum = (priceFruit * kgFruit + priceVegetables * kgVegetables) / 1.94;
            Console.WriteLine($"{sum:f2}");
        }
       
    }
}
