
using System.Text;

internal class ParkingController
{
    private List<ParkingSpot> parkingSpots;

    public ParkingController()
    {
        parkingSpots = new List<ParkingSpot>();
    }

    public string CreateParkingSpot(List<string> args)
    {
        if (parkingSpots.FirstOrDefault(p => p.Id == int.Parse(args[0])) != null) return
                $"Parking spot {args[0]} is already registered!";
        switch (args[2])
        {
            case "subscription":
                parkingSpots.Add(new SubscriptionParkingSpot(
                    int.Parse(args[0]), bool.Parse(args[1]), double.Parse(args[3]), args[4]));
                break;
            case "car":
                parkingSpots.Add(new CarParkingSpot(
                    int.Parse(args[0]), bool.Parse(args[1]), double.Parse(args[3])));
                break;
            case "bus":
                parkingSpots.Add(new BusParkingSpot(
                    int.Parse(args[0]), bool.Parse(args[1]), double.Parse(args[3])));
                break;
            default:
                return "Unable to create parking spot!";
        }
        return $"Parking spot {args[0]} was successfully registered in the system!";
    }

    public string ParkVehicle(List<string> args)
    {
        ParkingSpot parkingSpot = parkingSpots.FirstOrDefault(s => s.Id == int.Parse(args[0]));
        if (parkingSpot == null) return $"Parking spot {args[0]} not found!";
        if (parkingSpot.ParkVehicle(args[1], int.Parse(args[2]), args[3])) return
        $"Vehicle {args[1]} parked at {args[0]} for {args[2]} hours.";
        return $"Vehicle {args[1]} can't park at {args[0]}.";
    }

    public string FreeParkingSpot(List<string> args)
    {
        ParkingSpot parkingSpot = parkingSpots.FirstOrDefault(s => s.Id == int.Parse(args[0]));
        if (parkingSpot == null) return $"Parking spot {args[0]} not found!";
        if (parkingSpot.Occupied)
        {
            parkingSpot.Occupied = false ;
            return $"Parking spot {args[0]} is now free!";
        }
        return $"Parking spot {args[0]} is not occupied.";
    }

    public string GetParkingSpotById(List<string> args)
    {
        ParkingSpot parkingSpot = parkingSpots.FirstOrDefault(s => s.Id == int.Parse(args[0]));
        if (parkingSpot == null) return $"Parking spot {args[0]} not found!";
        return parkingSpot.ToString();
    }

    public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(List<string> args)
    {
        ParkingSpot parkingSpot = parkingSpots.FirstOrDefault(s => s.Id == int.Parse(args[0]));
        if (parkingSpot == null) return $"Parking spot {args[0]} not found!";
        StringBuilder builder = new StringBuilder();
        parkingSpot.GetAllParkingIntervalsByRegistrationPlate(args[1]).ForEach(s => builder.AppendLine(s.ToString()));
        return builder.ToString();
    }

    public string CalculateTotal(List<string> args)
    {
        double sum = parkingSpots.Select(p => p.CalculateTotal()).Sum();
        return $"Total revenue from the parking: {sum:F2} BGN";
    }

}

