using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Food_Shortage
{
    internal class Rebel : IBuyer
    {
        string name;
        int age;
        string group;
        int food;
        public Rebel(string name, int age, string group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
            Food = 0;
        }
        public string Name { get { return name; } }
        public int Food { get { return food; } set { food = value; } }
        public void BuyFood()
        {
            Food += 5;
        }
    }
}
