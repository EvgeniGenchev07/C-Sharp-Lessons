using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Най_често_срещано_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            byte count1 = 0;
            byte count2 = 0;
            int num = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = 0; j < nums.Count; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count1++;
                    }
                }
                if (count1>count2)
                {
                    count2 = count1;
                    num = nums[i];
                    count1 = 0;
                }
            }
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
