using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Food_Shortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,IBuyer> people = new Dictionary<string, IBuyer>();
            for (int i = 0; i < n; i++)
            {
                string[] input  = Console.ReadLine().Split(' ');
                if (input.Length <= 3) people.Add(input[0],new Rebel(input[0], int.Parse(input[1]), input[2]));
                else people.Add(input[0],new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
            }
            string buyer = Console.ReadLine();
            while (buyer != "End")
            {
                foreach (var item in people)
                {
                    if(item.Key == buyer) item.Value.BuyFood();
                }
                buyer = Console.ReadLine();
            }
            int totalFood = 0;
            foreach (var item in people)
            {
                totalFood+=item.Value.Food;
            }
            Console.WriteLine(totalFood);
        }
    }
}
