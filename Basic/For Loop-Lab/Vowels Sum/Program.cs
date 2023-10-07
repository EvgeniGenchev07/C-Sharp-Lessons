using System;

namespace Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int sum = 0;
            for (int i = a.Length-1;0<=i ;i-- )
            {
                char symbol = a[i];
                if (symbol == 'a') 
                {
                    sum += 1;
                }
                else
                {
                    sum += 0;
                }
                if (symbol == 'e') 
                {
                    sum += 2;
                }
                else
                {
                    sum += 0;
                }
                if (symbol == 'i') 
                { 
                    sum+=3;
                }
                else
                {
                    sum += 0;
                }
                if (symbol == 'o') 
                {
                    sum+=4;
                }
                else
                {
                    sum += 0;
                }
                if (symbol == 'u') 
                {
                    sum += 5;
                }
                else
                {
                    sum += 0;
                }
               

            }
            Console.WriteLine(sum);
        }
    }
}
