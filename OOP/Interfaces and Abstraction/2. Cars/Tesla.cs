using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cars
{
    internal class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int batteries)
        {
            Model = model;
            Color = color;
            Battery = batteries;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set;}
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} {GetType().Name} {Model} with {Battery} Batteries\n\r{Start()}\n\r{Stop()}";
        }
    }
}
