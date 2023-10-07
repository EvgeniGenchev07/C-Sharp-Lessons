using System;

namespace Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = -1;
            string b = "";
            string a = Console.ReadLine();
            while (true)
            {
                if (b == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {l} books.");
                    break;
                }
                else if (b != a)
                {
                    l++;
                    b = Console.ReadLine();
                }
                else if (a == b)
                {
                    Console.WriteLine($"You checked {l} books and found it.");
                    break;
                }
            }
        }
    }
}
