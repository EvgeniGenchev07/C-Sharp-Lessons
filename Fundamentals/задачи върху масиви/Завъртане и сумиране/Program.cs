using System;
using System.Collections.Generic;
using System.Linq;

namespace Завъртане_и_сумиране
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
            int roast = int.Parse(Console.ReadLine());
            int num;
            int sum;
            int[] total= new int[arr.Count];
            for (int r = 0; r < roast; r++)
            {
                num=arr[arr.Count - 1];
                arr.Insert(0,num);
                arr.RemoveAt(arr.Count-1);
                for (int i = 0; i <arr.Count ; i++)
                {
                    sum = arr[i] + total[i];
                    total[i] = sum;
                } 
                
                
            }
            Console.WriteLine(string.Join(" ",total));
        }
    }
}
