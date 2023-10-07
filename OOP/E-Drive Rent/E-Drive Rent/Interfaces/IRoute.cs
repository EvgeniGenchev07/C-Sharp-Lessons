using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Drive_Rent.Interfaces
{
    internal interface IRoute
    {
        public int RouteId { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public double Length { get; set; }
        public bool IsLooked { get; set; }
        public void LockRoute();

    }
}
