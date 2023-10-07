static void rectangle(int num)
{
    int length = 1;
    for (int i = 1; i <= 2*num-1; i++)
    {
        for (int j = 1; j <= length; j++)
        {
            Console.Write(j+" ");
        }
        if (i < num) length++;
        if (i >= num) length--;
        Console.WriteLine();
    }
}
int n = int.Parse(Console.ReadLine());
rectangle(n);
