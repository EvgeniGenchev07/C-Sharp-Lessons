using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Students[] student = new Students[n];
            double[] grades = new double[n];
            double hightGrade = 0;
            int mark = 0;
            for (int i = 0; i < n; i++)
            {
                List<string> info = Console.ReadLine().Split(' ').ToList();
                grades[i]=double.Parse(info[2]);
                student[i] = new Students(info[0], info[1], double.Parse(info[2]));
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (hightGrade < grades[j])
                    {
                        hightGrade = grades[j];
                        mark = j;
                    }
                }
                grades[mark] = 0.00;
                student[mark].Output();
                hightGrade = 0;
                
            }  

                
            
        }
    }
}
