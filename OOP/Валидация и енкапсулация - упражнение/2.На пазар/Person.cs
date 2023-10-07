using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _2.На_пазар
{
    internal class Person
    {
        string name;
        int money;
        List<string> bag;
        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            bag = new List<string>();
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length == 0) throw new ArgumentException("Name cannot be empty");
                name = value;
            }
        }
        public int Money
        {
            get { return money; }
            set
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be nagative");
                }
                 money = value; 
            }

        }
        public List<string> Bag
        {
            get { return bag; }
            set { bag = value; }
        }
        public void Print()
        {
            if (bag.Count != 0)
            {
                Console.Write($"{name} - ");
                Console.Write(string.Join(", ", bag));
                Console.WriteLine();
            }
            else Console.WriteLine($"{name} - Nothing bought");
        }
    }
}
