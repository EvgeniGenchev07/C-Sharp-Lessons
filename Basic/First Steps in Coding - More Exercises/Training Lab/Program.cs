using System;

namespace Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine()); 
            double areaw = w * 100 - 100;
            int areaw1 = Convert.ToInt32(areaw);
            int areaW = areaw1 / 70;
            double areah = h * 100;
            int areah1 = Convert.ToInt32(areah);
            int areaH = areah1 / 120;
            int areaA = (areaW * areaH) - 3;
            Console.WriteLine(areaA);
            
        }
    }
}
