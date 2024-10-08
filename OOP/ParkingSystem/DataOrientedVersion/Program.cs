
Dictionary<int, int> idPosition = new Dictionary<int, int>();
int capacity = 4;
ParkingInterval[][] parkingIntervals = new ParkingInterval[capacity][];
double[] Price = new double[capacity];
bool[] Occupied = new bool[capacity];
char[] Type = new char[capacity];

bool isRunning = true;
int index = 1;
while (isRunning)
{
    string[] lineArgs = Console.ReadLine().Split(":");
    try
    {
        switch (lineArgs[0])
        {
            case "CreateParkingSpot":
                {
                    int id = int.Parse(lineArgs[1]);
                    string returnLine = null;
                    bool occupied = bool.Parse(lineArgs[2]);
                    char type = lineArgs[3][0];
                    double price = double.Parse(lineArgs[4]);
                    if (idPosition.ContainsKey(id))
                    {
                        returnLine = $"Parking spot {id} is already registered!";
                    }
                    else if (type != 'b' && type != 'c' && type != 's')
                    {
                        returnLine = "Unable to create parking spot!";
                    }
                    else
                    {
                        if (index > capacity) Allocating();
                        idPosition.Add(id, index);
                        Price[index] = price;
                        Occupied[index] = occupied;
                        Type[index] = type;
                        returnLine = $"Parking spot {id} was successfully registered in the system!";
                    }
                    Console.WriteLine(returnLine);
                }
                break;
            case "ParkVehicle":

                Console.WriteLine(ParkingController.ParkVehicle(int.Parse(lineArgs[1]),
                    lineArgs[2], int.Parse(lineArgs[3]), lineArgs[4]));
                break;
            case "FreeParkingSpot":
                {
                    int id = int.Parse(lineArgs[1]);
                    string returnLine = null;
                    if (!idPosition.ContainsKey(id)) returnLine = $"Parking spot {id} not found!";
                    else if (Occupied[idPosition[id]])
                    {
                        Occupied[idPosition[id]] = false;
                        returnLine = $"Parking spot {id} is now free!";
                    }
                    else returnLine = $"Parking spot {id} is not occupied.";
                    Console.WriteLine(returnLine);
                }
                break;
            case "GetParkingSpotById":
                {
                    string returnLine = null;
                    int id = int.Parse(lineArgs[1]);
                    if (!idPosition.ContainsKey(id)) returnLine = $"Parking spot {id} not found!";
                    else
                    {
                        int position = idPosition[id];
                        string type = null;
                        switch (Type[position])
                        {
                            case 'c':
                                type = "car";
                                break;
                            case 'b':
                                type = "bus";
                                break;
                            case 's':
                                type = "subscription";
                                break;
                        }
                        returnLine = $@"> Parking Spot #{id}
> Occupied: {Occupied[position]}
> Type: {type}
> Price per hour: {Price[position]:f2} BGN";
                    }
                    Console.WriteLine(returnLine);
                }
                break;
            case "GetParkingIntervalsByParkingSpotIdAndRegistrationPlate":
                {
                    int id = int.Parse(lineArgs[1]);
                    string plate = lineArgs[2];
                    if (!idPosition.ContainsKey(id)) Console.WriteLine($"Parking spot {id} not found!");
                    else
                    {
                        int pos = idPosition[id];
                        double price = Price[pos];
                        for (int i = 0; i < parkingIntervals[pos].Length; i++)
                        {
                            if (parkingIntervals[pos][i].RegistrationPlate == plate)
                            {
                                int hours = parkingIntervals[pos][i].HoursParked;
                                Console.WriteLine($@"> ParkingSpot #{id}
> RegistrationPlate: {plate}
> HoursParked: {hours} hours
> Revenue: {hours} BGN");
                            }
                        }
                    }
                }
                break;
            case "CalculateTotal":
                {
                    double sum = 0;
                    double price = 0;
                    for (int i = 0; i < Type.Length; i++)
                    {
                        price = Price[i];
                        if (Type[i] != 's')
                        {
                            for (int j = 0; j < parkingIntervals[i].Length; j++)
                            {
                                sum += parkingIntervals[i][j].HoursParked * price;
                            }
                        }
                    }
                    Console.WriteLine($"Total revenue from the parking: {sum:F2} BGN");
                }
                break;
            case "End":
                isRunning = false;
                break;
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }

}

static string ParkVehicle(int id, string registration, int hoursParked, string type)
{
    ParkingSpot parkingSpot = parkingSpots.FirstOrDefault(s => s.Id == id);
    if (parkingSpot == null) return $"Parking spot {id} not found!";
    if (parkingSpot.Type != type ||
        parkingSpot.Occupied ||
        (parkingSpot.Type == "subscription"
        && ((parkingSpot as SubscriptionParkingSpot).RegistrationPlate == registration))) return
                $"Vehicle {registration} can't park at {id}.";
    parkingSpot.ParkingIntervals.Add(new ParkingInterval(parkingSpot, registration, hoursParked));
    parkingSpot.Occupied = true;
    return $"Vehicle {registration} parked at {id} for {hoursParked} hours.";

}
