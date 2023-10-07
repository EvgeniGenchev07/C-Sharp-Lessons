using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2.Телефонен_указател
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split(' ');
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phoneBook.Add(input[1], input[2]);

                }
                else
                {

                    if (phoneBook.ContainsKey(input[1]))
                    { foreach (var item in phoneBook)
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
