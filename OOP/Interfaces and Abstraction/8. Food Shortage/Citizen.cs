
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Food_Shortage
{
    internal class Citizen : IBuyer
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        private int food;
        public Citizen(string name,int age, string id,string birthdate)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthdate = birthdate;
            Food = 0;
        }
        public int Food { get { return food; } set { food = value; } }
        public string Name { get { return name; } }
        public void BuyFood()
        {
            Food += 10;
        }
    }
}
