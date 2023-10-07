using System;

namespace Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            int t = 0;
            int v = 0;
            int g = 0;
            double h = 0;
            while (true)
            {
                string a = Console.ReadLine();
                if (a == "Finish")
                {
                    Console.WriteLine($"Total tickets: {h}");
                    Console.WriteLine($"{((t/h) * 100):f2}% student tickets.");
                    Console.WriteLine($"{((g /h) * 100):f2}% standard tickets.");
                    Console.WriteLine($"{((v / h) * 100):f2}% kids tickets.");
                    break;
                }
                int b = int.Parse(Console.ReadLine());
                
                while (true)
                {
                    if (b == s)
                    {
                        Console.WriteLine($"{a} - 100.00% full.");
                        h += s;
                        s = 0;
                        break;
                    }
                    
                   string c = Console.ReadLine();
                    

                    if (c!="End")
                    {
                        s++;
                        if (c == "student")
                        {
                            t++;
                        }
                        if (c == "kid")
                        {
                            v++;
                        }
                        if (c=="standard")
                        {
                            g++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{a} - {((s/b) * 100):f2}% full.");
                        h += s;
                        s = 0;
                        break;
                    }
                }
            }

        }
    }
}
