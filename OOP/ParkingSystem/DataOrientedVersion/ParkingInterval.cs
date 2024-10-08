
public struct ParkingInterval
{
    private int hoursParked;
    private string registrationPlate;

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
}
