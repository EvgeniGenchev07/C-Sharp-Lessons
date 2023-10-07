using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Drive_Rent.Interfaces;
using E_Drive_Rent.Repositories;
using E_Drive_Rent.Models;
using System.Net.Sockets;

namespace E_Drive_Rent
{
    internal class Controller : IController
    {
        UserRepository users = new UserRepository();
        VehicleRepository vehicles = new VehicleRepository();
        RouteRepository routes = new RouteRepository();

        public void AllowRoute(string startPoint, string endPoint, double length)
        {
            IRoute route = new Route(startPoint, endPoint, length, routes.GetAll().Count + 1);
            List<IRoute> routesCopy = routes.GetAll().ToList();
            var routeCopy = routesCopy.FirstOrDefault(r => r.StartPoint == startPoint && r.EndPoint == endPoint);
            if (routeCopy != null)
            {
                if (routeCopy.Length == length)
                {
                    throw new ArgumentException($"{startPoint}/{endPoint} - {length} km is already added in our platform.");
                }
                else if (routeCopy.Length < length)
                {
                    throw new ArgumentException($"{startPoint}/{endPoint} shorter route is already added in our platform.");
                }
                else if (routeCopy.Length > length)
                {
                    routes.FindById(routeCopy.RouteId.ToString()).LockRoute();
                    routes.AddModel(route);
                    Console.WriteLine($"{startPoint}/{endPoint} - {length} km is unlocked in our platform.");
                }
            }
            else
            {
                routes.AddModel(route);
            }

        }

        public void MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            var user = users.FindById(drivingLicenseNumber);
            var vehicle = vehicles.FindById(licensePlateNumber);
            var route = routes.FindById(routeId);
            if (user.IsBlocked == true)
            {
                throw new ArgumentException($"User {drivingLicenseNumber} is blocked in the platform! Trip is not allowed.");
            }
            else if (vehicle.IsDamage == true)
            {
                throw new ArgumentException($"Vehicle {licensePlateNumber} is damaged! Trip is not allowed.");
            }
            else if (route.IsLooked == true)
            {
                throw new ArgumentException($"Route {routeId} is locked! Trip is not allowed.");
            }
            else
            {
                vehicle.Drive(route.Length);
                if (isAccidentHappened == true)
                {
                    vehicle.IsDamage = true;
                    user.DecreaseRating();
                }
                else
                {
                    user.IncreaseRating();
                }
                Console.WriteLine(vehicle.ToString());
            }
        }

        public void RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
        {
            IUser user = new User(firstName, lastName, drivingLicenseNumber);
            bool check = users.FindById(drivingLicenseNumber) != null;
            if (check)
            {
                throw new ArgumentException($"{drivingLicenseNumber} is already registered in our platform.");
            }
            users.AddModel(user);
            Console.WriteLine($"{firstName} {lastName} is registered successfully with DLN-{drivingLicenseNumber}");
        }

        public void RepairVehicles(int count)
        {
            var vehiclesCopy = vehicles.GetAll()
                .ToList()
                .Where(v => v.IsDamage == true)
                .OrderBy(v => v.Brand)
                .ThenBy(v => v.Model)
                .ToList();
            int countOfRepairedVehicles = 0;
            if (vehiclesCopy.Count < count)
            {
                count = vehiclesCopy.Count;
            }
            for (; countOfRepairedVehicles < count; countOfRepairedVehicles++)
            {
                vehiclesCopy[countOfRepairedVehicles].IsDamage = false;
            }
            Console.WriteLine($"{countOfRepairedVehicles} vehicles are successfully repaired!");
        }

        public void UploadVehicle(string vehicleTypeName, string brand, string model, string licensePlateNumber)
        {
            bool check = vehicles.FindById(licensePlateNumber) != null;
            if (check)
            {
                throw new ArgumentException($"{licensePlateNumber} belongs to another vehicle.");
            }
            if (vehicleTypeName == "PassengerCar")
            {
                IVehicle vehicle = new PassengerCar(brand, model.ToString(), licensePlateNumber);
                vehicles.AddModel(vehicle);
                Console.WriteLine($"{brand} {model} is uploaded successfully with LPN-{licensePlateNumber}");
            }
            else if (vehicleTypeName == "CargoVan")
            {
                IVehicle vehicle = new CargoVan(brand, model.ToString(), licensePlateNumber);
                vehicles.AddModel(vehicle);
                Console.WriteLine($"{brand} {model} is uploaded successfully with LPN-{licensePlateNumber}");
            }
            else
            {
                throw new ArgumentException($"{vehicleTypeName} is not accessible in our platform.");
            }

        }

        public void UsersReport()
        {
            Console.WriteLine("*** E-Drive-Rent ***");
            users.GetAll()
                .ToList()
                .OrderByDescending(u => u.Rating)
                .ThenBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .ToList()
                .ForEach(u => Console.WriteLine(u.ToString()));
        }
    }
}
