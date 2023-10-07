using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Най_дълга_нарастваще__подредица
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> longRow1 = new List<int>();
            List<int> longRow2 = new List<int>();

            int prev = 0; int next = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                prev = nums[i];
                if (i == 0) longRow1.Add(prev);
                for (int j = i; j < nums.Count-1; j++)
                {
                    
                    next = nums[j+1];
                    if (prev < next && longRow1[longRow1.Count - 1] <prev)
                    {
                        longRow1.Add(prev);
                    }
                    prev= next;
                }
                if (longRow1.Count>longRow2.Count)
                {
                    longRow2 = longRow1;
                }
            }
            Console.WriteLine(string.Join(" ",longRow2));
        }
    }
}
