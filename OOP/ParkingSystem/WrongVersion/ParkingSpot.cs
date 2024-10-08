

public abstract class ParkingSpot
{
    private int id;
    private bool occupied;
    private string type;
    private double price;
    protected List<ParkingInterval> parkingIntervals;
    public List<ParkingInterval> ParkingIntervals
    {
        get { return parkingIntervals; }
        set { parkingIntervals = value; }
    }
    public int Id
    {
        get
        {
            return id;
        }
        
        set
        {
            id = value;
        }
    }

    public bool Occupied
    {
        get
        {
            return occupied;
        }
        
        set
        {
            occupied = value;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
        
        set
        {
            type = value;
        }
        
    }

    public double Price
    {
        get
        {
            return price;
        }
        
        set
        {
            if (value <= 0) throw new ArgumentException("Parking price cannot be less or equal to 0!");
            price = value;
        }
    }

    public ParkingSpot(int id, bool occupied, string type, double price)
    {
        this.Id = id;
        this.Occupied = occupied;
        this.Type = type;
        this.Price = price;
        parkingIntervals = new List<ParkingInterval>();
    }

    public virtual bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if (Type != type || Occupied) return false;
        ParkingIntervals.Add(new ParkingInterval(this, registrationPlate, hoursParked));
        Occupied = true;
        return true;
    }

    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
        return ParkingIntervals.FindAll(p => p.RegistrationPlate == registrationPlate);
    }

    public virtual double CalculateTotal()
    {
       return ParkingIntervals.Select(i => i.Revenue).Sum();
    }

    public override string ToString()
    {
        return $@"> Parking Spot #{Id}
> Occupied: {Occupied}
> Type: {Type}
> Price per hour: {Price:f2} BGN";
    }

}
