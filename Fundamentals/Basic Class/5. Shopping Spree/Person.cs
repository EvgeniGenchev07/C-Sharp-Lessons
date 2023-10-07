using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _5.Shopping_Spree
{
    internal class Person
    {
        string name;
        int money;
        List<string> bag;
        public Person(string name, int money)
        {
            this.name = name;
            this.money = money;
            bag = new List<string>();
        }
        public string Name
        {
            get { return name; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
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
                Console.Write(string.Join(", ",bag));
                Console.WriteLine();
            }
            else Console.WriteLine($"{name} - Nothing bought");
        }
    }
}
