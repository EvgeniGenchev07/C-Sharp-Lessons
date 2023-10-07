using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List <Car>();
            string[] input = new string[3];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                cars.Add(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
            }
            input = Console.ReadLine().Split(' ');
            while (input[0]!="End")
            {
                cars.ForEach(car => { if (car.Model == input[1]) { car.FuelCalculating(int.Parse(input[2])); } });
                input = Console.ReadLine().Split(' ');
            }
            cars.ForEach(car => car.Print());
        }
    }
}
