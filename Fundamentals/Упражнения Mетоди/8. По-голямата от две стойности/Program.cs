static int typeInt(int a, int b)
{
    int max = 0;
    if (a < b) max = b;
    else max = a;
    return max;
}
static char typeChar(char a, char b)
{
    char max = ' ';
    if (a < b) max = b;
    else max = a;
    return max;
}
static string typeString(string a, string b)
{
    string max = null;
    if (a.Length < b.Length) max = b;
    else max = a;
    return max;
}
string type = Console.ReadLine();
if (type == "int")
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(typeInt(a,b));
}
else if (type == "char")
{
    char a = char.Parse(Console.ReadLine());
    char b = char.Parse(Console.ReadLine());
    Console.WriteLine(typeChar(a, b));
}
else if (type == "string")
{
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    Console.WriteLine(typeString(a, b));
}