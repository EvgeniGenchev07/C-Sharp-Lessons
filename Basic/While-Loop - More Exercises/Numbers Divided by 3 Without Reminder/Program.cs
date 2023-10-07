using System;

namespace Numbers_Divided_by_3_Without_Reminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (true)
            {
                if (a < 99)
                {
                    a += 3;
                    Console.WriteLine(a);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
