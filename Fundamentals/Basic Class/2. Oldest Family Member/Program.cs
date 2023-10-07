using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family[] familyMember = new Family[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                familyMember[i] = new Family(input[0], int.Parse(input[1]));
            }
            familyMember = familyMember.OrderByDescending(member=>member.Age).ToArray();
            familyMember[0].Print();
        }
    }
}
