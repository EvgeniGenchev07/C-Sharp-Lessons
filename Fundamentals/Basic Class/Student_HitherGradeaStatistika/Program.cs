using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_HitherGradeaStatistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n1 = byte.Parse(Console.ReadLine());
            Student BestStudent = new Student();
            List < double> grade= new List<double>();
            for (int i = 0; i < n1; i++)
            {
                List<string> students = Console.ReadLine().Split(' ').ToList();
                BestStudent.Names(students[0], students[1]);
                BestStudent.Grades(double.Parse(students[2]));
                grade.Add(double.Parse(students[2]));
            }
            byte n2 = n1;
            for (int j = 0; j < n1; j++)
            {
                double highGrade = 0;
                int i = 0;
             
                for (; i < n2; i++)
                {
                    
                    if (highGrade < grade[i])
                    {
                        highGrade = grade[i];
                    }
                }
                grade.Remove(highGrade);
                i= 0;
                n2--;
                BestStudent.HitherGrade(highGrade);
                BestStudent.output();
            }
        }
    }
}
