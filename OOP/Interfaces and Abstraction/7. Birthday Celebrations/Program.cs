
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Birthday_Celebrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<IBirthable> list = new List<IBirthable>();
            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Pet":
                        list.Add(new Pet(input[1], input[2]));
                        break;
                    case "Citizen":
                        list.Add(new Citizen(input[1], int.Parse(input[2]), input[3], input[4]));
                        break;
                }
                input = Console.ReadLine().Split(' ');
            }
            string date = Console.ReadLine();
            bool statement = true;
            foreach (var item in list)
            {
                string[] value = item.Birthdate.Split('/');
                if (value[2] == date)
                {
                    Console.WriteLine(item.DateSearching());
                    statement = false;
                }
                
            }
            if (statement)
            {
                Console.WriteLine("<empty output>");
            }
        }
    }
}
