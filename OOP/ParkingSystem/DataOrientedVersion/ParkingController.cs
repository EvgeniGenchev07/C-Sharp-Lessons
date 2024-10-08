
using System.Text;

internal static class ParkingController
{
    private static List<ParkingSpot> parkingSpots;

    static ParkingController()
    {
        parkingSpots = new List<ParkingSpot>();
    }

    public static string CreateParkingSpot(int id, bool occupied, string type, double price)
    {
        if (parkingSpots.FirstOrDefault(p => p.Id == id) != null) return
                $"Parking spot {id} is already registered!";
        if (type != "bus" && type != "car" && type != "subscription") return "Unable to create parking spot!";
        parkingSpots.Add(new ParkingSpot(id, occupied, type, price));
        return $"Parking spot {id} was successfully registered in the system!";
    }

    public static string ParkVehicle(int id, string registration, int hoursParked, string type)
    {
        ParkingSpot parkingSpot = parkingSpots.FirstOrDefault(s => s.Id == id);
        if (parkingSpot == null) return $"Parking spot {id} not found!";
        if (parkingSpot.Type != type || parkingSpot.Occupied) return
                    $"Vehicle {registration} can't park at {id}.";
        parkingSpot.ParkingIntervals.Add(new ParkingInterval(parkingSpot, registration, hoursParked));
        parkingSpot.Occupied = true;
        return $"Vehicle {registration} parked at {id} for {hoursParked} hours.";

    }

    public static string FreeParkingSpot(int id)
    {
        ParkingSpot parkingSpot = parkingSpots.FirstOrDefault(s => s.Id == id);
        if (parkingSpot == null) return $"Parking spot {id} not found!";
        if (parkingSpot.Occupied)
        {
            parkingSpot.Occupied = false;
            return $"Parking spot {id} is now free!";
        }
        return $"Parking spot {id} is not occupied.";
    }

    public static string GetParkingSpotById(int id)
    {
        ParkingSpot parkingSpot = parkingSpots.FirstOrDefault(s => s.Id == id);
        if (parkingSpot == null) return $"Parking spot {id} not found!";
        return parkingSpot.ToString();
    }

    public static string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(int id, string registration)
    {
        ParkingSpot parkingSpot = parkingSpots.FirstOrDefault(s => s.Id == id);
        if (parkingSpot == null) return $"Parking spot {id} not found!";
        StringBuilder builder = new StringBuilder();
        parkingSpot.ParkingIntervals
            .FindAll(p => p.RegistrationPlate == registration)
            .ForEach(s =>
            builder.AppendLine(s.ToString()));
        return builder.ToString();
    }

    public static string CalculateTotal()
    {
        double sum = parkingSpots
            .Select(p => p.ParkingIntervals
            .Select(i => i.Revenue())
            .Sum())
            .Sum();
        return $"Total revenue from the parking: {sum:F2} BGN";
    }

}

