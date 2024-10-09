
using System;
using System.ComponentModel.Design;

Dictionary<int, int> idPosition = new Dictionary<int, int>();
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
                        if (index > capacity)
                        {
                            capacity *= 2;
                            Allocate(Price,capacity);
                            Allocate(Type,capacity);
                            Allocate(Registrations,capacity);
                            Allocate(Occupied,capacity);
                            Allocate(ParkingIntervals,capacity);
                        }
                        idPosition.Add(id, index);
                        Price[index] = price;
                        Occupied[index] = occupied;
                        Type[index] = type;
                        ParkingIntervals[index] = new ParkingInterval[capacity];
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
                    int hours = int.Parse(lineArgs[3]);
                    char type = lineArgs[4][0];
                    if (idPosition.ContainsKey(id))
                    {
                        int pos = idPosition[id];
                        if (Type[pos] != type ||
                        Occupied[pos] ||
                        (Type[pos] == 's'
                        && Registrations[pos] == plate)) returnLine =
                                $"Vehicle {plate} can't park at {id}.";
                        else
                        {
                            if (ParkingIntervals[pos].Length < ParkingIntervals[pos].Count())
                            {
                                Allocate(ParkingIntervals[pos], ParkingIntervals.Length * 2);
                            }
                            ParkingInterval parkingInterval = new ParkingInterval();
                            parkingInterval.HoursParked = hours;
                            parkingInterval.RegistrationPlate = plate;
                            ParkingIntervals[pos][ParkingIntervals[pos].Length-1] = parkingInterval;
                            returnLine = $"Vehicle {plate} parked at {id} for {hours} hours.";
                        }
                    }
                    else returnLine = $"Parking spot {id} not found!";
                }
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
                        for (int i = 0; i < ParkingIntervals[pos].Length; i++)
                        {
                            if (ParkingIntervals[pos][i].RegistrationPlate == plate)
                            {
                                int hours = ParkingIntervals[pos][i].HoursParked;
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
                            for (int j = 0; j < ParkingIntervals[i].Length; j++)
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
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
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
