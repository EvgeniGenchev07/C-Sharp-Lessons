using System;

namespace Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
            //Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot
            // Всички останали са "unknown"





            string a = Console.ReadLine();
            if (a == "banana" || a == "apple" || a == "kiwi" || a == "cherry" || a == "lemon"|| a == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (a == "tomato" || a == "cucumber" || a == "pepper" || a == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
