using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CombinationGenerator
{
    internal class Program
    {
        public static void Generator(int[] nums,int n,string[] num,int l = 0)
        {
            if (num[n-1] !=null)
            {
                Console.WriteLine(string.Join("",num));
                return;
            }
            for (int i = 1; i < n; i++)
            {
                num[l] = $"{nums[i]}";
                Generator(nums, n, num,l+1);
            }
        }
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Generator(nums, n, new string[n]);
        }
    }
}
