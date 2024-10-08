using System;
using System.Collections.Generic;
using System.Text;

internal class SubscriptionParkingSpot : ParkingSpot
{
    private string registrationPlate;
    public string RegistrationPlate
    {
        get
        {
            return this.registrationPlate;
        }
        
        set
        {
            if(string.IsNullOrEmpty(value)) throw new ArgumentNullException(
                "Registration plate can’t be null or empty!");
            this.registrationPlate = value;
        }
    }

    public SubscriptionParkingSpot(int id, bool occupied, double price, string registrationPlate) : base(id, occupied, "subscription", price)
    {
        RegistrationPlate = registrationPlate;
    }

    public override bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if(RegistrationPlate==registrationPlate) return base
                .ParkVehicle(registrationPlate,hoursParked,type);
        return false;
    }

    public override double CalculateTotal()
    {
        return 0;
    }
}

