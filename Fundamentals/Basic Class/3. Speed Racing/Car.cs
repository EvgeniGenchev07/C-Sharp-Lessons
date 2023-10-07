using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Speed_Racing
{
    internal class Car
    {
        string model;
        double fuelAmount;
        double consumption;
        int travelDistance;
        public Car(string model, double fuelAmount, double consumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.consumption = consumption;
        }

       
        public string Model
        {
            get { return model; }
        }
        
        public void FuelCalculating(int distance)
        {
            double fuelForTravel = distance * consumption;
            if (fuelForTravel > fuelAmount) Console.WriteLine("Insufficient fuel for the drive");

            else
            {
                fuelAmount -= fuelForTravel;
                travelDistance += distance;
            }
        }
        public void Print()
        {
            Console.WriteLine($"{model} {fuelAmount:f2} {travelDistance:f2}");
        }
    }
}
