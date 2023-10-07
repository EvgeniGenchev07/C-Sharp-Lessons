
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Border_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List <IIdentifiable> list = new List<IIdentifiable>();
            while (input[0] != "End")
            {
                if (input.Length < 3)
                {
                    list.Add(new Robot(input[0], input[1]));
                }
                else list.Add(new Citizen(input[0],int.Parse(input[1]), input[2]));
                input = Console.ReadLine().Split(' ');
            }
            string el = Console.ReadLine();
            foreach (var item in list)
            {
                item.IdSearching(el);
            }
        }
    }
}
