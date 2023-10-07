using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Generating_Combinations
{
    internal class Program
    {
        static void Generater(int n)
        {
            output[0] = n;
            for (int i = n+1; i <= nums[nums.Length - 1]; i++)
            {
                output[] = i;
                Print();
            }
            if (n < nums[nums.Length-1])
            {
                Generater(n+=1);
            }
        }
        static void Print()
        {
            Console.WriteLine(string.Join(" ",output));
        }
        static int[] output;
        static int[] nums;
        static int count;
        static void Main(string[] args)
        {
            nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            count = int.Parse(Console.ReadLine());
            output = new int[count];
            Generater(1);
        }
    }
}
