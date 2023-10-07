using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                cars[i]=(new Car(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4]));
            }
            string type = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                cars[i].CarFinder(type, i);
            }
        }
    }
}
