using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.На_пазар
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] peopleInput = Console.ReadLine().Split(';');
                List<Person> people = new List<Person>();
                for (int i = 0; i < peopleInput.Count(); i++)
                {
                    string[] input = peopleInput[i].Split('=');
                    people.Add(new Person(input[0], int.Parse(input[1])));
                }
                string[] productsInput = Console.ReadLine().Split(';');
                List<Product> products = new List<Product>();
                for (int i = 0; i < peopleInput.Count(); i++)
                {
                    string[] input = productsInput[i].Split('=');
                    products.Add(new Product(input[0], int.Parse(input[1])));
                }
                string[] buy = Console.ReadLine().Split();
                while (buy[0] != "END")
                {
                    people.ForEach(person =>
                    {
                        if (person.Name == buy[0])
                        {
                            products.ForEach(product =>
                            {
                                if (product.Name == buy[1])
                                {
                                    if (person.Money >= product.Price)
                                    {
                                        person.Money -= product.Price;
                                        person.Bag.Add(product.Name);
                                    }
                                    else { Console.WriteLine($"{person.Name} can't afford {product.Name}"); }
                                }
                            });
                        }
                    });
                    buy = Console.ReadLine().Split();
                }
                people.ForEach(person => person.Print());
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
