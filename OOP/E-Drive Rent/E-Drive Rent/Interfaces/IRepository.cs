using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Drive_Rent.Interfaces
{
    internal interface IRepository<T>
    {
        void AddModel(T item);
        bool RemoveById(string identifier);
        T FindById(string identifier);
        IReadOnlyCollection<T> GetAll();
    }
}
