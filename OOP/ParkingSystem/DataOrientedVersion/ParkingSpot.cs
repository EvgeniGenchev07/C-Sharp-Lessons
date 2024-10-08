

public struct ParkingSpot
{
    private double price;
    public List<ParkingInterval> ParkingIntervals {  get; set; }
    public int Id { get; set; }

    public bool Occupied { get; set; }

    public string Type { get; set; }

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
}
