using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Drive_Rent.Interfaces;

namespace E_Drive_Rent.Repositories
{
    internal class RouteRepository : IRepository<IRoute>
    {
        private List<IRoute> routes = new List<IRoute>();

        public void AddModel(IRoute item)
        {
            routes.Add(item);
        }
        public IRoute FindById(string identifier)
        {
            var route = routes.FirstOrDefault(r => r.RouteId == int.Parse(identifier));
            if (route == null) return null;
            return route;
        }
        public IReadOnlyCollection<IRoute> GetAll()
        {
            return routes.AsReadOnly();
        }
        public bool RemoveById(string identifier)
        {
            var route = routes.FirstOrDefault(r => r.RouteId == int.Parse(identifier));
            routes.Remove(route);
            if (route == null) return false;
            return true;
        }
    }
}
