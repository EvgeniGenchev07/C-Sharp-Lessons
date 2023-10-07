using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Drive_Rent.Interfaces
{
    internal interface IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public double Rating { get; set; }
        public bool IsBlocked { get; set; }
        public void IncreaseRating();
        public void DecreaseRating();
        public string ToString();
    }
}
