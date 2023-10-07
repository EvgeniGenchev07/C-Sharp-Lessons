using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Търсене_на_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> p = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            byte count = 0;
            nums.RemoveRange(p[0], nums.Count - p[0]);
            nums.RemoveRange(0, p[1]);
            foreach(int num in nums)
            {
                if (num == p[2]) count++;
            }
            if (count!=0) Console.WriteLine("Yes!");
            else Console.WriteLine("No!");
            Console.ReadKey();
        }
    }
}
