using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _7.Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> person = new List<People>();
            List <string> personInfo = Console.ReadLine().Split(' ').ToList();
            List<int> age = new List<int>();
            while (personInfo[0] != "End")
            {
                person.Add(new People(personInfo[0], personInfo[1], personInfo[2]));
                age.Add(int.Parse(personInfo[2]));
                personInfo = Console.ReadLine().Split(' ').ToList();
            }
            int n = age.Count;
            for (int i = 0; i < n; i++)
            {
                int ageMin = int.MaxValue;
                int index = 0;
                for (int j = 0; j < age.Count; j++)
                {
                    if (ageMin > age[j])
                    {
                        ageMin = age[j];
                        index = j;
                    }
                }
                person[index].output();
                age[index] = int.MaxValue;
            }
        }
    }
}
