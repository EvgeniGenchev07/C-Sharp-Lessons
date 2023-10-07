using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Подобрен_телефонен_указател
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
            string[] input = Console.ReadLine().Split(' ');
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phoneBook.Add(input[1], input[2]);

                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                else
                {

                    if (phoneBook.ContainsKey(input[1]))
                    {
                        foreach (var item in phoneBook)
                        {
                            if (input[1] == item.Key)
                            {
                                Console.WriteLine($"{item.Key} -› {item.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
