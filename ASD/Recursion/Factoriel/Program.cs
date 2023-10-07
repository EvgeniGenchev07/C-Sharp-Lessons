using System.Numerics;

internal class Program
{
    public static BigInteger[] memo = new BigInteger[1000000];
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write(Factorial(n));
        Console.Write(Factorial(n+1000));
        Console.Write(Factorial(n+2000));
        Console.Write(Factorial(n+3000));
        Console.Write(Factorial(n+4000));
        Console.Write(Factorial(n+5000));
        Console.Write(Factorial(n+6000));
        Console.Write(Factorial(n+7000));

    }
    public static BigInteger Factorial(int n)
    {

        if (n == 0)
        {
            return 1;
        }
        if (memo[n] == 0)
        {
            memo[n] = Factorial(n - 1) * n;
        }
        return memo[n];
     }

}