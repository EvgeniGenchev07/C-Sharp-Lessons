using System;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double sum = 0;
            double s = 0;  
            double b = a * 100;
            
                if (b >= 200)
                {
                  s = b / 200;
                    sum +=Math.Floor(s);
                   
                    b -= Math.Floor(s) * 200;
                }
                if (b >= 100)
                {
                    s = b / 100;
                    
                    sum += Math.Floor(s);
                    b -= Math.Floor(s) * 100;
                }
                if (b >= 50)
                {
                    s = b / 50;
                    
                    sum += Math.Floor(s);
                    b -= Math.Floor(s) * 50;
                }
                if (b >= 20)
                {
                    s = b / 20;
                    
                    sum += Math.Floor(s);
                    b -= Math.Floor(s) * 20;
                }
                if (b >= 10)
                {
                    s = b / 10;
                    
                    sum += Math.Floor(s);
                    b -= Math.Floor(s) * 10;
                }
                if (b >= 5)
                {
                    s = b / 5;
                    
                    sum += Math.Floor(s);
                    b -= Math.Floor(s) * 5;
                }
                if (b >= 2)
                {
                    s = b / 2;
                  
                    sum += Math.Floor(s);
                    b -= Math.Floor(s) * 2;
                }
                if (b >= 1)
                {
                    s = b / 1;
                    
                    sum += Math.Floor(s);
                    b -= Math.Floor(s) * 1;
                }
                Console.WriteLine(sum);   
        }
    }
}
