static double pow(double n, double pow)
{
    double total=Math.Pow(n, pow);
    return total;
}
double n = double.Parse(Console.ReadLine());
double powN = double.Parse(Console.ReadLine());
Console.WriteLine(pow(n,powN));