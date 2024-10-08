

public class ParkingSpot
{
    private double price;
    public List<ParkingInterval> ParkingIntervals {  get; private set; }
    public int Id { get; private set; }

    public bool Occupied { get; set; }

    public string Type { get; private set; }

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
        Id = id;
        Occupied = occupied;
        Type = type;
        Price = price;
        ParkingIntervals = new List<ParkingInterval>();
    }

    public override string ToString()
    {
        return $@"> Parking Spot #{Id}
> Occupied: {Occupied}
> Type: {Type}
> Price per hour: {Price:f2} BGN";
    }

}
