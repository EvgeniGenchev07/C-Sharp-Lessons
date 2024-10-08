using System.Text;

/*класът ParkingController трябва да е статичен, 
понеже той играе ролята на utility class.
наследяването на и неговото абстрахиране е напълно ненужно, 
защото логиката на наследниците не се променя само се забавя програмата,
заради многото скачания в паметта
Revenue свойството трябва попринцип да е метод, понеже не описва самия обект.
Няма логика да има try-catch,ако не искат да се прихващат изключения.
Няма логика и да не се отпечатват низовете директно на конзолата,
защото така потребителя не знае какво се случва.
Как очакват да се добави нов интервал, ако мястото е протектед и не искат нищо да се добавя.
Защо CalculateTotal приема параметри, като не ги използва.
Дублиране на методи.*/
ParkingController controller = new ParkingController();
StringBuilder stringBuilder = new StringBuilder();
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
                stringBuilder.AppendLine(controller.CreateParkingSpot(lineArgs));
                break;
            case "ParkVehicle":
                stringBuilder.AppendLine(controller.ParkVehicle(lineArgs));
                break;
            case "FreeParkingSpot":
                stringBuilder.AppendLine(controller.FreeParkingSpot(lineArgs));
                break;
            case "GetParkingSpotById":
                stringBuilder.AppendLine(controller.GetParkingSpotById(lineArgs));
                break;
            case "GetParkingIntervalsByParkingSpotIdAndRegistrationPlate":
                stringBuilder.AppendLine(controller.GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(lineArgs));
                break;
            case "CalculateTotal":
                stringBuilder.AppendLine(controller.CalculateTotal(lineArgs));
                break;
            case "End":
                isRunning = false;
                break;
        }
    }
    catch (ArgumentException ex)
    {
        stringBuilder.AppendLine(ex.Message);
    }

}

Console.WriteLine(stringBuilder.ToString().Trim());
