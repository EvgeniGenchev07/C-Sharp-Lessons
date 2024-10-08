using System;
using System.Collections.Generic;
using System.Text;

public class ParkingInterval
{
    private ParkingSpot parkingSpot;
    private int hoursParked;
    private string registrationPlate;

    public ParkingSpot ParkingSpot
    {
        get
        {
            return parkingSpot;
        }

        set
        {
            parkingSpot = value;
        }
    }


    public string RegistrationPlate
    {
        get
        {
            return registrationPlate;
        }

        set
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(
                "Registration plate can’t be null or empty!");
            registrationPlate = value;
        }
    }


    public int HoursParked
    {
        get
        {
            return hoursParked;
        }
        set
        {
            if (value <= 0) throw new ArgumentException("Hours parked can’t be zero or negative!");
            hoursParked = value;
        }
    }

    public double Revenue
    {
        get
        {
            if (ParkingSpot is SubscriptionParkingSpot) return 0;
            return ParkingSpot.Price * HoursParked;
        }
    }

    public ParkingInterval(ParkingSpot parkingSpot, string registrationPlate, int hoursParked)
    {
        ParkingSpot = parkingSpot;
        RegistrationPlate = registrationPlate;
        HoursParked = hoursParked;
    }

    public override string ToString()
    {
        return $@"> ParkingSpot #{ParkingSpot.Id}
> RegistrationPlate: {RegistrationPlate}
> HoursParked: {HoursParked} hours
> Revenue: {Revenue} BGN";
    }
}