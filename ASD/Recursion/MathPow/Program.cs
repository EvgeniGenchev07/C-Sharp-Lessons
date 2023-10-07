using System.Numerics;

int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
Console.WriteLine(Pow(n,k));
static BigInteger Pow( int n, int k)
{
    if(k==0) return 1;
    if(k%2==1)return Pow(n, k - 1) * n;
    BigInteger h= Pow(n, k/2);
    return h * h;
}
