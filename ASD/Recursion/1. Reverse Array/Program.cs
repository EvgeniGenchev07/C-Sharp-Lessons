using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_Array
{
    internal class Program
    {
        public static void Reverse(string[] nums,int index,List<string> num)
        {
            if (index < 0)
            {
                Console.WriteLine(string.Join(" ", num));
                return;
            }
            num.Add(nums[index]);
            Reverse(nums,index-1,num);
        }
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            Reverse(nums,nums.Length-1,new List<string>());
        }
    }
}
