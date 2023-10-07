
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Drive_Rent.Interfaces;

namespace E_Drive_Rent.Repositories
{
    internal class UserRepository : IRepository<IUser>
    {
        private List<IUser> users = new List<IUser>();

        public void AddModel(IUser item)
        {
            users.Add(item);
        }

        public IUser FindById(string identifier)
        {
            var user = users.FirstOrDefault(u => u.DrivingLicenseNumber == identifier);
            if (user == null) return null;
            return user;
        }

        public IReadOnlyCollection<IUser> GetAll()
        {
            return users.AsReadOnly();
        }

        public bool RemoveById(string identifier)
        {
            var user = users.FirstOrDefault(u => u.DrivingLicenseNumber == identifier);
            users.Remove(user);
            if (user != null) return true;
            return false;
        }
    }
}
