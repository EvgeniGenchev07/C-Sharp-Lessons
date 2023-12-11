using System.Net.Http.Headers;

bool flag = true;
while (flag)
{
    try
    {
        List<int> collection = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        int num = 0;
        int count = 0;
        int resultCount = 0;
        int result = 0;
        for (int i = 0; i < collection.Count; i++)
        {
            if (i == 0 || num == collection[i]) count++;
            else
            {
                num = collection[i];
                count = 1;
            }
            if (resultCount < count)
            {
                result = num;
                resultCount = count;
            }
        }
        Console.WriteLine($"{result} => {resultCount}");
        flag = false;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
