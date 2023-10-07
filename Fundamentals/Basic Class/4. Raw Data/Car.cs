using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _4.Raw_Data
{
    internal class Car
    {
        string model;
        List<Engine> engines;
        List<Cargo> cargoes;
        int enginePower;
        int cargoWeight;
        string cargoType;
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            this.model = model;
            this.enginePower = enginePower;
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
            engines = new List<Engine>();
            cargoes = new List<Cargo>();
            engines.Add(new Engine(engineSpeed, enginePower));
            cargoes.Add(new Cargo(cargoWeight,cargoType));
        }
        public List<Cargo> Cargoes
        {
            get { return cargoes; }
        }

        public void CarFinder(string type,int number)
        {
            if (type == "flamable" && cargoType==type && enginePower>250)
            {
                Console.WriteLine(model);
            }
            if (type == "fragile" && type == cargoType && cargoWeight < 1000)
            {
                Console.WriteLine(model);
            }
        }
    }
}
