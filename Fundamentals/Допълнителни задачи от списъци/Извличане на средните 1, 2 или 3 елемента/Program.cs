using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Извличане_на_средните_1__2_или_3_елемента
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int p = 0;
            if (nums.Length % 2 == 0)
            { 
                p=nums.Length/2-1;
                Console.Write("{ " + nums[p]);
                p++;
                Console.Write(", " + nums[p] + " }");
            }

            else if (nums.Length == 1) 
            {
                Console.WriteLine("{ " + nums[0]+" }");
            }
            else if (nums.Length % 2 != 0)
            {
                p = (nums.Length-1)/ 2 - 1;
                Console.Write("{ "+nums[p]);
                p++;
                Console.Write(", " + nums[p]+", ");
                p++;
                Console.Write(nums[p]+" }");
            }
            Console.ReadKey();
        }
    }
}
