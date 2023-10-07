static double C0(double F0)
{
    F0 = (F0 - 32) * 5 / 9;
    return F0;
}
double F0 = double.Parse(Console.ReadLine());
Console.WriteLine($"{C0(F0):f2}");
