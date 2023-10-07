using System;

namespace School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            double sum = 0;
            double sum2 = 0;
            if (b == "boys")
            {
                if (a == "Winter")
                {
                    sum2 = 9.6 * d * c;
                    if (c <=9)
                    {
                        sum = sum2;
                    }
                    else if  (c < 20)
                    {
                        sum = sum2 - sum2 * 0.05;
                    }
                    else if (c < 50)
                    {
                        sum = sum2 - sum2 * 0.15;
                    }
                    else if (c >=50)
                    {
                        sum = sum2 - sum2 * 0.5;
                    }

                    Console.WriteLine($"Judo {sum:f2} lv.");
                }
                else if (a == "Spring")
                {
                    sum2 = 7.2 * d * c;
                    if (c <= 9)
                    {
                        sum = sum2;
                    }
                    else if (c >= 10 && c < 20)
                    {
                        sum = sum2 - sum2 * 0.05;
                    }
                    else if (c < 50)
                    {
                        sum = sum2 - sum2 * 0.15;
                    }
                    else if (c >= 50)
                    {
                        sum = sum2 - sum2 * 0.5;
                    }
                    Console.WriteLine($"Tennis {sum:f2} lv.");
                }
                else if (a == "Summer")
                {
                    sum2 = 15 * d * c;
                    if (c <= 9)
                    {
                        sum = sum2;
                    }
                    else if (c < 20)
                    {
                        sum = sum2 - sum2 * 0.05;
                    }
                    else if (c < 50)
                    {
                        sum = sum2 - sum2 * 0.15;
                    }
                    else if (c >= 50)
                    {
                        sum = sum2 - sum2 * 0.5;
                    }
                    Console.WriteLine($"Football {sum:f2} lv.");
                }
            }
            if (b == "girls")
            {
                if (a == "Winter")
                {
                    sum2 = 9.6 * d * c;
                    if (c <= 9)
                    {
                        sum = sum2;
                    }
                    else if (c < 20)
                    {
                        sum = sum2 - sum2 * 0.05;
                    }
                    else if (c < 50)
                    {
                        sum = sum2 - sum2 * 0.15;
                    }
                    else if (c >= 50)
                    {
                        sum = sum2 - sum2 * 0.5;
                    }
                    
                    
                    Console.WriteLine($"Gymnastics {sum:f2} lv.");
                }
                else if (a == "Spring")
                {
                    sum2 = 7.2 * d * c;
                    if (c <= 9)
                    {
                        sum = sum2;
                    }
                    else if (c < 20)
                    {
                        sum = sum2 - sum2 * 0.05;
                    }
                    else if (c < 50)
                    {
                        sum = sum2 - sum2 * 0.15;
                    }
                    else if (c >= 50)
                    {
                        sum = sum2 - sum2 * 0.5;
                    }
                    Console.WriteLine($"Athletics {sum:f2} lv.");
                }
                else if (a == "Summer")
                {
                    sum2 = 15 * d * c;
                    if (c <= 9)
                    {
                        sum = sum2;
                    }
                    else if (c < 20)
                    {
                        sum = sum2 - sum2 * 0.05;
                    }
                    else if (c < 50)
                    {
                        sum = sum2 - sum2 * 0.15;
                    }
                    else if (c >= 50)
                    {
                        sum = sum2 - sum2 * 0.5;
                    }
                    Console.WriteLine($"Volleyball {sum:f2} lv.");
                }
            }
            if (b == "mixed")
            {
                if (a == "Winter")
                {
                    sum2 = 10 * d * c;
                    if (c <= 9)
                    {
                        sum = sum2;
                    }
                    else if (c < 20)
                    {
                        sum = sum2 - sum2 * 0.05;
                    }
                    else if (c < 50)
                    {
                        sum = sum2 - sum2 * 0.15;
                    }
                    else if (c >= 50)
                    {
                        sum = sum2 - sum2 * 0.5;
                    }
                    

                    Console.WriteLine($"Ski {sum:f2} lv.");
                }
                else if (a == "Spring")
                {
                    sum2 = 9.5 * d * c;
                    if (c <= 9)
                    {
                        sum = sum2;
                    }
                    else if (c < 20)
                    {
                        sum = sum2 - sum2 * 0.05;
                    }
                    else if (c < 50)
                    {
                        sum = sum2 - sum2 * 0.15;
                    }
                    else if (c >= 50)
                    {
                        sum = sum2 - sum2 * 0.5;
                    }



                    Console.WriteLine($"Cycling {sum:f2} lv.");
                }
                else if (a == "Summer")
                {
                    sum2 = 20 * d * c;
                    if (c <= 9)
                    {
                        sum = sum2;
                    }
                    else if (c < 20)
                    {
                        sum = sum2 - sum2 * 0.05;
                    }
                    else if (c < 50)
                    {
                        sum = sum2 - sum2 * 0.15;
                    }
                    else if (c >= 50)
                    {
                        sum = sum2 - sum2 * 0.5;
                    }

                    Console.WriteLine($"Swimming {sum:f2} lv.");
                }
            }
        }
    }
}
