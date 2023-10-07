using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace E_Drive_Rent.Interfaces
{
    internal interface IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string LicensePlateNumber { get; set; }
        public bool IsDamage { get; set; }
        public void Drive(double length);
    }
}
