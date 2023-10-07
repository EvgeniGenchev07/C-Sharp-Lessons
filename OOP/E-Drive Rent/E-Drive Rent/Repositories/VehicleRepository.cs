using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Drive_Rent.Interfaces;

namespace E_Drive_Rent.Repositories
{
    internal class VehicleRepository : IRepository<IVehicle>
    {
        private List<IVehicle> vehicles = new List<IVehicle>();

        public void AddModel(IVehicle item)
        {
            vehicles.Add(item);
        }

        public IVehicle FindById(string identifier)
        {
            var vehicle = vehicles.FirstOrDefault(v => v.LicensePlateNumber == identifier);
            if (vehicle == null) return null;
            return vehicle;
        }

        public IReadOnlyCollection<IVehicle> GetAll()
        {
            return vehicles.AsReadOnly();
        }

        public bool RemoveById(string identifier)
        {
            var vehicle = vehicles.FirstOrDefault(v => v.LicensePlateNumber == identifier);
            vehicles.Remove(vehicle);
            if (vehicle == null) return false;
            return true;
        }
    }
}
