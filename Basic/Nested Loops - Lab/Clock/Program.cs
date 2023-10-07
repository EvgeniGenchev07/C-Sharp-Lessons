    using System;

    namespace Clock
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                for (int h = 0; h <=23; h++)
                {
                    for (int i = 0; i <= 59; i++)
                    {
                        if (i < 10)
                        {
                            Console.WriteLine($"{h}:{i:d2}");
                        }
                        else
                        {
                            Console.WriteLine($"{h}:{i}");
                        }
                    }
                }
            }
        }
    }
