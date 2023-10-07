using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Drive_Rent
{
    internal class Engine
    {
        private Controller controller;
        public Engine()
        {
            this.controller = new Controller();
        }
        public void Input()
        {
            var input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                try
                {
                    switch (input[0])
                    {
                        case "RegisterUser":
                            controller.RegisterUser(input[1], input[2], input[3]);
                            break;
                        case "UploadVehicle":
                            controller.UploadVehicle(input[1], input[2], input[3], input[4]);
                            break;
                        case "AllowRoute":
                            controller.AllowRoute(input[1], input[2], double.Parse(input[3]));
                            break;
                        case "MakeTrip":
                            controller.MakeTrip(input[1], input[2], input[3], bool.Parse(input[4]));
                            break;
                        case "RepairVehicles":
                            controller.RepairVehicles(int.Parse(input[1]));
                            break;
                        case "UsersReport":
                            controller.UsersReport();
                            break;
                        default:
                            throw new ArgumentException("Invalid command!");

                    }
                }
                catch (ArgumentException ex)
                {
                    Output(ex);
                }
                input = Console.ReadLine().Split();
            }
        }
        public void Output(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
