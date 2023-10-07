using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List <Truck>();
            List <string> info = Console.ReadLine ().Split (' ').ToList();
            List<string> carModel = new List<string>();
            List<string> truckModel = new List<string>();
            double carPower = 0;
            double truckPower = 0;
            byte count = 0;
            while (info[0]!="End") 
            {
                count++;
                if (info[0]=="car")
                {
                    cars.Add(new Car(info[1], info[2],int.Parse( info[3])));
                    carModel.Add(info[1]);
                    carPower+=int.Parse(info[3]);
                }
                else if (info[0] == "truck")
                {
                    trucks.Add(new Truck(info[1], info[2], int.Parse(info[3])));
                    truckPower+=int.Parse(info[3]);
                    truckModel.Add(info[1]);
                }
                info = Console.ReadLine().Split(' ').ToList();
            }
            string catalogue = Console.ReadLine ();
            List<string> list = new List<string> ();
            while (catalogue!= "Close the Catalogue")
            {
                list.Add (catalogue);
                catalogue = Console.ReadLine ();
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < carModel.Count; j++)
                {
                    if (carModel[j] == list[i])
                    {
                        cars[j].output();
                    }

                }
                for (int j = 0; j < truckModel.Count; j++)
                {
                    if (truckModel[j] == list[i])
                    {
                            trucks[j].output();
                    }
                }
            }
            Console.WriteLine($"Cars have average horsepower of {(carPower/cars.Count):f2}");
            Console.WriteLine($"Trucks have average horsepower of {(truckPower / trucks.Count):f2)}");
        }
    }
}
