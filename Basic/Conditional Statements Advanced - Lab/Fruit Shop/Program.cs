using System;

namespace Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Магазин за плодове през работните дни работи на следните цени:
            //плод banana  apple orange  grapefruit kiwi    pineapple grapes
            //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85
            //Събота и неделя магазинът работи на по - високи цени:
            //  плод banana  apple  orange  grapefruit  kiwi   pineapple grapes
            //цена    2.70    1.25    0.90    1.60    3.00       5.60    4.20

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double p = 0;
            double sum = 0;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        p = 2.50;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "apple":
                        p = 1.2;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "orange":
                        p = 0.85;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "grapefruit":
                        p = 1.45;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "kiwi":
                        p = 2.7;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "pineapple":
                        p = 5.5;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "grapes":
                        p = 3.85;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                        default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        p = 2.70;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "apple":
                        p = 1.25;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "orange":
                        p = 0.9;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "grapefruit":
                        p = 1.6;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "kiwi":
                        p = 3;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "pineapple":
                        p = 5.6;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "grapes":
                        p = 4.20;
                        sum = p * a;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            sum = p * a;
        }
    }
}
