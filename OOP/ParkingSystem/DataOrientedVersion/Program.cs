
Dictionary<int, Location> idPosition = new Dictionary<int, Location>();
int capacity = 4;
ParkingInterval[][] ParkingIntervals = new ParkingInterval[capacity][];
double[] Price = new double[capacity];
bool[] Occupied = new bool[capacity];
string[] Registrations = new string[capacity];
char[] Type = new char[capacity];

bool isRunning = true;
int index = 0;
while (isRunning)
{
    string[] lineArgs = Console.ReadLine().Split(":");
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
                else if (lineArgs[3] != "bus" && lineArgs[3] != "car" && lineArgs[3] != "subscription")
                {
                    returnLine = "Unable to create parking spot!";
                }
                else
                {
                    if (index >= capacity)
                    {
                        capacity *= 2;
                        Price = Allocate(Price, capacity);
                        Type = Allocate(Type, capacity);
                        Registrations = Allocate(Registrations, capacity);
                        Occupied = Allocate(Occupied, capacity);
                        ParkingIntervals = Allocate(ParkingIntervals, capacity);
                    }
                    idPosition.Add(id, new Location() { index = index, ParkIntervalIndex = 0 });
                    Price[index] = price;
                    Occupied[index] = occupied;
                    Type[index] = type;
                    ParkingIntervals[index] = new ParkingInterval[capacity];
                    if (type == 's')
                    {
                        Registrations[index] = lineArgs[5];
                    }
                    index++;
                    returnLine = $"Parking spot {id} was successfully registered in the system!";
                }
                Console.WriteLine(returnLine);
            }
            break;
        case "ParkVehicle":
            {
                string returnLine = null;
                int id = int.Parse(lineArgs[1]);
                string plate = lineArgs[2];
                if (string.IsNullOrEmpty(plate))
                {
                    Console.WriteLine("Registration plate can’t be null or empty!");
                    continue;
                }
                int hours = int.Parse(lineArgs[3]);
                if (hours <= 0)
                {
                    Console.WriteLine("Hours parked can’t be zero or negative!");
                    continue;
                }
                char type = lineArgs[4][0];
                if (idPosition.ContainsKey(id))
                {
                    Location location = idPosition[id];
                    int pos = location.index;
                    ParkingInterval[] currentIndexParkingIntervals = ParkingIntervals[pos];
                    if (Type[pos] != type ||
                    Occupied[pos] ||
                    (Type[pos] == 's'
                    && !(Registrations[pos] == plate))) returnLine =
                            $"Vehicle {plate} can't park at {id}.";
                    else
                    {
                        if (location.ParkIntervalIndex >= currentIndexParkingIntervals.Length)
                        {
                            ParkingIntervals[pos] = Allocate(currentIndexParkingIntervals,
                                currentIndexParkingIntervals.Length * 2);
                        }
                        ParkingInterval parkingInterval =
                            ParkingIntervals[pos][location.ParkIntervalIndex];
                        parkingInterval.HoursParked = hours;
                        parkingInterval.RegistrationPlate = plate;
                        ParkingIntervals[pos][location.ParkIntervalIndex] = parkingInterval;
                        location.ParkIntervalIndex++;
                        idPosition[id] = location;
                        Occupied[pos] = true;
                        returnLine = $"Vehicle {plate} parked at {id} for {hours} hours.";
                    }
                }
                else returnLine = $"Parking spot {id} not found!";
                Console.WriteLine(returnLine);
            }
            break;
        case "FreeParkingSpot":
            {
                int id = int.Parse(lineArgs[1]);
                string returnLine = null;
                if (!idPosition.ContainsKey(id)) returnLine = $"Parking spot {id} not found!";
                else if (Occupied[idPosition[id].index])
                {
                    Occupied[idPosition[id].index] = false;
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
                    int position = idPosition[id].index;
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
                    int pos = idPosition[id].index;
                    double price = Price[pos];
                    ParkingInterval[] currentParkingIntervals = ParkingIntervals[pos];
                    for (int i = 0; i < currentParkingIntervals.Length; i++)
                    {
                        if (currentParkingIntervals[i].RegistrationPlate == plate)
                        {
                            int hours = currentParkingIntervals[i].HoursParked;
                            Console.WriteLine($@"> ParkingSpot #{id}
> RegistrationPlate: {plate}
> HoursParked: {hours} hours
> Revenue: {(price * hours):f2} BGN");
                        }
                    }
                }
            }
            break;
        case "CalculateTotal":
            {
                double sum = 0;
                double price = 0;
                for (int i = 0; i < index; i++)
                {
                    int currentParkingIntervalIndex = idPosition.ElementAt(i).Value.ParkIntervalIndex;
                    price = Price[i];
                    if (Type[i] != 's')
                    {
                        for (int j = 0; j <= currentParkingIntervalIndex; j++)
                        {
                            sum += ParkingIntervals[i][j].HoursParked * price;
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
static T[] Allocate<T>(T[] buffer, int capacity)
{
    T[] newBuffer = new T[capacity];
    int length = buffer.Length;
    for (var i = 0; i < length; i++)
    {
        newBuffer[i] = buffer[i];
    }
    return newBuffer;
}
internal struct Location
{
    public int index;
    public int ParkIntervalIndex;
}