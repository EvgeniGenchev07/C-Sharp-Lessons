using E_Drive_Rent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Drive_Rent.Models
{
    internal class Route : IRoute
    {
        private string startPoint;
        private string endPoint;
        private double length;
        private int routeId;
        private bool isLooked;
        public Route(string startPoint, string endPoint, double length, int routeId)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.length = length;
            this.routeId = routeId;
        }
        public string StartPoint
        {
            get
            {
                return startPoint;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("StartPoint cannot be null or whitespace!");
                }
                startPoint = value;
            }
        }
        public string EndPoint
        {
            get
            {
                return endPoint;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("EndPoint cannot be null or whitespace!");
                }
                endPoint = value;
            }
        }
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Length cannot be less than 1 kilometer.");
                }
                length = value;
            }
        }
        public int RouteId
        {
            get
            {
                return routeId;
            }
            set
            {
                routeId = value;
            }
        }
        public bool IsLooked
        {
            get
            {
                return isLooked;
            }
            set
            {
                isLooked = value;
            }
        }
        public void LockRoute()
        {
            IsLooked = true;
        }
    }
}
