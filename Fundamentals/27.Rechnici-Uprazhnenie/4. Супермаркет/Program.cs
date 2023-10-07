using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Супермаркет
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, Dictionary<string, int>> products = new Dictionary<string, Dictionary<string, int>>();
            while (input[0] != "stocked")
            {
                if (products.ContainsKey(input[0]))
                {
                    int a = 0;
                    foreach (var item in products[input[0]])
                    {
                        a = item.Value;
                    }
                    Dictionary<string, int> values = new Dictionary<string, int>();
                    values.Add(input[1], int.Parse(input[2]) + a);
                    products[input[0]] = values;
                }
                else
                {
                    Dictionary<string, int> values = new Dictionary<string, int>();
                    values.Add(input[1], int.Parse(input[2]));
                    products.Add(input[0], values);
                }
                input = Console.ReadLine().Split(' ');
            }
                    double total = 0;
                    foreach (var item in products)
                    { 
                        Console.Write(item.Key + ": ");
                         foreach (var i in item.Value)
                          {
                          double sum = Math.Round(double.Parse(i.Key) * i.Value, 2);
                             total += sum;
                             Console.Write("$" + i.Key + " * ");
                    Console.Write(i.Value + " = $");
                    Console.Write($"{sum:f2}");
                }
                    Console.WriteLine();
                      }
            Console.WriteLine(new string('-' , 30));
            Console.WriteLine($"Grand Total: ${total:f2}");
        }
    }
}
