using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using E_Drive_Rent.Interfaces;

namespace E_Drive_Rent.Models
{
    internal abstract class Vehicle : IVehicle
    {
        private string brand;
        private string model;
        private double maxMileages;
        private string licensePlateNumber;
        private int batteryLevel;
        private bool isDamage;
        protected Vehicle(string brand, string model, double maxMileage, string licensePlateNumber)
        {
            this.brand = brand;
            this.model = model;
            maxMileages = maxMileage;
            this.licensePlateNumber = licensePlateNumber;
            BatteryLevel = 100;
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Brand cannot be null or whitespace!");
                }
                brand = value;
            }
        }
        private double MaxMileages
        {
            get
            {
                return maxMileages;
            }
            set
            {
                maxMileages = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be null or whitespace!");
                }
                model = value;
            }
        }
        public string LicensePlateNumber
        {
            get
            {
                return licensePlateNumber;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("License plate number is required!");
                }
                licensePlateNumber = value;
            }
        }
        public bool IsDamage
        {
            get
            {
                return isDamage;
            }
            set
            {
                isDamage = value;
            }
        }
        private int BatteryLevel
        {
            get
            {
                return batteryLevel;
            }
            set
            {
                batteryLevel = value;
            }
        }
        public void Drive(double mileage)
        {
            BatteryLevel -= (int)Math.Round((mileage / (double)MaxMileages) * 100, 0);
        }
        public void Recharge()
        {
            BatteryLevel = 100;
        }
        public void ChangeStatus()
        {
            IsDamage = IsDamage ? false : true;
        }
        public override string ToString()
        {

            string build = IsDamage ? "damage" : "OK";
            return $"{Brand} {Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel}% Status: {build}";
        }
    }
}
