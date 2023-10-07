int n = int.Parse(Console.ReadLine());
Bits(n, "");
static void Bits(int n, string bit)
{
    if (n == 0)
    {
        Console.WriteLine(bit);
        return;
    }
    Bits(n-1, bit + "0");
    Bits(n - 1, bit + "1");
}
