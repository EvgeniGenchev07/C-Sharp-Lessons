using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Vehicle_Catalogue
{
    internal class Truck
    {
        string model;
        string color;
        int power;
        public Truck(string model, string color, int power) 
        {
            this.model = model;
            this.color = color;
            this.power = power;
        }
        public void output()
        {
            Console.WriteLine("Type: Truck");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Horsepower: {power}");
        }
    }
}
