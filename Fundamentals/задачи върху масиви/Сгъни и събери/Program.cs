using System;
using System.Linq;

namespace Сгъни_и_събери
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Count();
            int[] startNum = new int[k/4];
            int[] endNum = new int[k / 4];
            int[] middleNum = new int[k / 2];
            int[] startAndEndNum = new int[k/2];
            int[] total = new int[k/2];
            int t1 = arr.Length - 1;
            int t2 =k/4 ;
            int sum = 1;
            for (int i = 0; i < k/4; i++)
            {
                startNum[i] = arr[i];
            }
            Array.Reverse(startNum);
            for (int i =0 ; i <k/4; i++)
            {
                endNum[i] = arr[t1];
                t1--;
            }
            for (int i = 0; i < k/2; i++)
            {
                middleNum[i] = arr[t2];
                t2++;
            }
            startNum.CopyTo(startAndEndNum, 0);
            endNum.CopyTo(startAndEndNum, endNum.Count());
            for (int i = 0; i < k/2; i++)
            {
                sum = middleNum[i] + startAndEndNum[i];
                total[i] = sum;
            }
            Console.WriteLine(string.Join(" ",total));
        }
    }
}
