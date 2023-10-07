using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Най_дълга_нарастваще_подредица
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List <int> nums1 = new List<int>();
            List <int> nums2 = new List<int>();
            List<int> nums3 = new List<int>();
            int count = 0;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                 if (i % 2 == 0)
                 {
                    nums1.Add(nums[i]);
                    for (int j = 0; j < nums.Count; j++)
                    {
                        if (nums[i] < nums[j]&& count<1)
                        {
                            count++;
                            num1 = nums[j];
                        }
                        else if (nums[i] < nums[j] && count < 2)
                        {
                            count++;
                            num2 = nums[j];
                        }
                        else if (nums[i] < nums[j] && count < 3)
                        {
                            num3 = nums[j];
                            count++;
                        }
                        if (num1<num2&&num2<num3)
                        {
                            nums1.Add(num1);
                            nums1.Add(num2);
                            nums1.Add(num3);
                        }
                        else if (num2 < num3 && num1 > num2)
                        {
                            nums1.Add(num2);
                            nums1.Add(num3);
                        }
                        else if (num1 < num2 && num3 < num2)
                        {
                            nums1.Add(num1);
                            nums1.Add(num2);
                        }
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ",nums1));
            Console.ReadKey();
        }
    }
}
