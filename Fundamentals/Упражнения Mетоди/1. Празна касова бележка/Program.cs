using System.Reflection;
static void Head()
{
    Console.WriteLine("CASH RECEIPT");
    Console.WriteLine("------------------------------");
}
static void Body()
{
    Console.WriteLine("Charged to_______________");
    Console.WriteLine("Received by______________");
}
static void End()
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("\u00A9 SoftUni");
}
static void first()
{
    Head();
    Body();
    End();
}
first();
