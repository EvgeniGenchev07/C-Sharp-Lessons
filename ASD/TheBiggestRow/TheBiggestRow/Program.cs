using System.Data;

//-3 5 2 10 -1 6 8 12 1 -3 5 -> -3 -1 6 8 12
//-1 -2 -3 -2 -1 0 4 5 67 80 10 15 20 -> -3 -2 -1 0 4 5 10 15 20
//1 -> 1
//7 3 5 8 -1 0 6 7 -> 3 5 6 7
//1 2 5 3 5 2 4 1 -> 1 2 3 5
//0 10 20 30 30 40 1 50 2 3 4 5 6 -> 0 1 2 3 4 5 6
//11 12 13 3 14 4 15 5 6 7 8 7 16 9 8 -> 3 4 5 6 7 8 16
//3 14 5 12 15 7 8 9 11 10 1 -> 3 5 7 8 9 11
bool flag = true;
while (flag)
{
    try
    {
        List<int> collection = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        List<int> currentRow = new List<int>();
        List<int> result = new List<int>();
        int index = 0;
        int lastIndex = 0;
        int firstIndex = 0;
        bool fill = true;
        while (true)
        {
            lastIndex = index;
            for (int i = index; i < collection.Count; i++)
            {
                if (fill || currentRow.Last() < collection[i])
                {
                    currentRow.Add(collection[i]);
                    fill = false;
                }
                else if (firstIndex == 0 && currentRow[0] > collection[i]) firstIndex = i;
                else if (index == lastIndex
                    && collection[i] < currentRow.Last()
                    && collection[i] > currentRow[0])
                {
                    index = i;
                }
            }
            if (result.Count() < currentRow.Count()) result = currentRow.ToList();
            for (int j = currentRow.Count() - 1; j >= 0; j--)
            {
                if (currentRow[j] > collection[index])
                {
                    currentRow.RemoveAt(j);
                    continue;
                }
                break;
            }
            if (lastIndex == index)
            {
                if (firstIndex == 0) break;
                index = firstIndex;
                firstIndex = 0;
                currentRow = new List<int>();
                fill = true;
            }
        }
        Console.WriteLine(string.Join(" ", result));
        flag = false;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
