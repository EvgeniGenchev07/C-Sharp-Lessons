static void square(int num)
{
    Console.WriteLine("--------");
    for (int i = 0; i < num-2; i++)
    {
        Console.WriteLine("-\\/\\/\\/-");
    }
    Console.WriteLine("--------");
}
int n = int.Parse(Console.ReadLine());
square(n);
