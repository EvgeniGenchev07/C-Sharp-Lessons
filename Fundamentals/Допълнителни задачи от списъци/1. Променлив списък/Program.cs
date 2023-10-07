using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Променлив_списък
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    int elementToDeleted = int.Parse(commands[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == elementToDeleted)
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int elementToInsert = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, elementToInsert);
                }

                commands = Console.ReadLine().Split().ToArray();
            }
            if (commands[0] == "Odd")
            {
                foreach (var element in numbers)
                {
                    if (element % 2 != 0)
                    {
                        Console.Write(element + " ");
                    }
                }
            }
            else
            {
                foreach (var element in numbers)
                {
                    if (element % 2 == 0)
                    {
                        Console.Write(element + " ");
                    }
                }
            }
        }
    }
}
