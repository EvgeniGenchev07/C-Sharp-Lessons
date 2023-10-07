using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Множество_от_сумите_на_последните_k_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(1);
            int j = 0;
            int t = k;
            for (int i = 0; i < n-2; i++)
            {
                int sum = 0;
                int count = 0;

                for (j = 0;  j < k; j++)
                {
                   count++;
                   if (nums.Count > k)
                   {
                    sum += nums[t];
                    t++;
                   }
                   else sum += nums[j];
                   if (k > nums.Count && nums.Count == count)
                   {
                    break;
                   }
                }
            
                nums.Add(sum);
                if (nums.Count > k)
                {
                t = nums.Count - k;

                }
            }
              foreach (var item in nums) Console.Write(item+" ");
              
            Console.ReadKey();
        }
    }
}
