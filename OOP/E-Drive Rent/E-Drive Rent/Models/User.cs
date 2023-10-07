using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Drive_Rent.Interfaces;

namespace E_Drive_Rent.Models
{
    internal class User : IUser
    {
        private string firstName;
        private string lastName;
        private string drivingLicenseNumber;
        private double rating;
        private bool isBlocked;
        public User(string firstName, string lastName, string drivingLicenseNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Rating = 0;
            this.DrivingLicenseNumber = drivingLicenseNumber;
            IsBlocked = false;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName cannot be null or whitespace!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("LastName cannot be null or whitespace!");
                }
                this.lastName = value;
            }
        }
        public string DrivingLicenseNumber
        {
            get
            {
                return this.drivingLicenseNumber;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Driving license number is required!");
                }
                this.drivingLicenseNumber = value;
            }
        }
        public double Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }
        public bool IsBlocked
        {
            get
            {
                return isBlocked;
            }
            set
            {
                isBlocked = value;
            }
        }
        public void IncreaseRating()
        {
            if (rating < 10) rating += 0.5;
        }
        public void DecreaseRating()
        {
            if (rating > 2) rating -= 2;
            else
            {
                rating = 0;
                IsBlocked = true;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} Driving license: {drivingLicenseNumber} Rating: {rating}";
        }
    }
}
