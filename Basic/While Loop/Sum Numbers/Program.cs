using System;

namespace Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int a = int.Parse(Console.ReadLine());
            
            int sum = 0;
            while (true)
            {
               
             if (a > sum)
                {

                int b = int.Parse(Console.ReadLine());
                sum += b;
                }
             else
                {
                    break;
                }


                    
                    
            }
            Console.WriteLine(sum);
        }
    }
}
