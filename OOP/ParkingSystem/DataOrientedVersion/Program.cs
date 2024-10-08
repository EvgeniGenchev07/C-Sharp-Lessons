bool isRunning = true;

while (isRunning)
{
    List<string> lineArgs = Console.ReadLine()
       .Split(":")
       .ToList();

    string command = lineArgs[0];

    lineArgs = lineArgs
        .Skip(1)
        .ToList();
    try
    {
        switch (command)
        {
            case "CreateParkingSpot":
                Console.WriteLine(ParkingController.CreateParkingSpot(int.Parse(lineArgs[0]),
                    bool.Parse(lineArgs[1]), lineArgs[2], double.Parse(lineArgs[3])));
                break;
            case "ParkVehicle":
                Console.WriteLine(ParkingController.ParkVehicle(int.Parse(lineArgs[0]), lineArgs[1], int.Parse(lineArgs[2]), lineArgs[3]));
                break;
            case "FreeParkingSpot":
                Console.WriteLine(ParkingController.FreeParkingSpot(int.Parse(lineArgs[0])));
                break;
            case "GetParkingSpotById":
                Console.WriteLine(ParkingController.GetParkingSpotById(int.Parse(lineArgs[0])));
                break;
            case "GetParkingIntervalsByParkingSpotIdAndRegistrationPlate":
                Console.WriteLine(ParkingController
                    .GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(int.Parse(lineArgs[0]), lineArgs[1]));
                break;
            case "CalculateTotal":
                Console.WriteLine(ParkingController.CalculateTotal());
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

