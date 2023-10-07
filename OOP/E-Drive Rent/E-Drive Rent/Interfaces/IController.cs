using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Drive_Rent.Interfaces
{
    internal interface IController
    {
        public void RegisterUser(string firstname, string lastname, string drivingLicenseNumber);
        public void UploadVehicle(string vehicleTypeName, string brand, string model, string licensePlateNumber);
        public void AllowRoute(string startPoint, string endPoint, double length);
        public void MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened);
        public void RepairVehicles(int count);
        public void UsersReport();
    }
}
