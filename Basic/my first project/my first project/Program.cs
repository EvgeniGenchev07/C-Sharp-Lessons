// See https://aka.ms/new-console-template for more information
//ctrl+k+c
//ctrl+k+u
//ctrl+d+k
//ctrl+s
//ctrl+d
//ctrl+z
//int age = int.Parse(Console.ReadLine()); "25"->25
//double height = double.Parse(Console.ReadLine()); "1.25"->1.25
string name = Console.ReadLine();
string surname = Console.ReadLine();
string age = Console.ReadLine();
string height = Console.ReadLine();
string phoneNumber = Console.ReadLine();
Console.WriteLine($"name: {name}");
Console.WriteLine($"surname: {surname}");
Console.WriteLine($"age: {age}");
Console.WriteLine($"height: {height:f2}cm");
Console.WriteLine($"Phone: {phoneNumber}");