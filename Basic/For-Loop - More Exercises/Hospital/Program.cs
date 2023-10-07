using System;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treated = 0;
            int untreated = 0;
            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i%3 == 0)
                {
                    if (treated < untreated)
                    {
                        doctors++;
                    }
                    else
                    {
                        doctors = 7;
                    }
                }
                if (patients <= doctors)
                { 
                    treated += patients;
                    untreated += 0;
                }
                else
                {
                    treated += doctors;
                    untreated += patients - doctors;
                }              
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
