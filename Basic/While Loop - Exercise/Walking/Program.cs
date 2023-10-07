using System;

namespace Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int sum = 0;
            int c = 0;

            while (true)
            {
                string a = Console.ReadLine();
                
                if (a != "Going home")
                {
                    b = int.Parse(a);
                    sum += b;
                    
                }
                else
                {
                    c = int.Parse(Console.ReadLine());
                    sum += c;
                    if (sum >= 10000)
                    {
                        int s = sum - 10000;
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{s} steps over the goal!");
                        break ;
                    }
                    else
                    {
                        int s = 10000 - sum;
                        Console.WriteLine($"{s} more steps to reach goal.");
                        break;
                    }
                }
                if (sum >= 10000)
                {
                    int s = sum - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{s} steps over the goal!");
                    break;
                }
            }
        }
    }
}
