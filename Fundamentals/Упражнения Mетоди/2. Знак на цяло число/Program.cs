using System.Reflection.Metadata;
static void Sign(int num)
{
	if (num<0)
	{
        Console.WriteLine($"The number {num} is negative.");
    }
    else if (num > 0)
    {
        Console.WriteLine($"The number {num} is positive.");
    }
    else
    {
        Console.WriteLine("The number 0 is zero.");
    }
}
int n = int.Parse(Console.ReadLine());
Sign(n);