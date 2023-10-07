using System;

namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //int age = int.Parse(Console.ReadLine());
           // bool isOfAge = age > 18;
           // if (isOfAge)
           // {
           //     Console.WriteLine("You can drive");
           // }
           // else
           // {
           //     Console.WriteLine("You can't drive");
           //}
           double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
                Console.WriteLine("Excellent!");
        }
    }
}
