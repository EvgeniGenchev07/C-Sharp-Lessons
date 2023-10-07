static double area(double a, double b)
{
    double area = a * b / 2;
    return area;
}
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
Console.WriteLine(area(a,b));
