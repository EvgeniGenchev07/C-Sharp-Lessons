List<int> input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
List<int> evenNums = new List<int>();
//for (int i = 0; i < input.Count - 1; i++)
//{
//    if (input[i] % 2 != 0 && input[i] < 0)
//    {
//        if (input[i + 1] % 2 != 0 && input[i + 1] < 0)
//        {
//            evenNums.Add(input[i]);
//            int j = i + 1;
//            while (j < input.Count)
//            {
//                if (input[j] % 2 != 0 && input[j] < 0) evenNums.Add(input[j]);
//                else
//                {
//                    break;
//                }
//                j++;
//            }
//            i = j - 1;
//        }
//    }
//}
int lastEdit = -2;
for (int i = 0; i < input.Count-1; i++)
{
    if (input[i] % 2 != 0 && input[i] < 0 && input[i + 1] % 2 != 0 && input[i + 1] < 0)
    {
        if(lastEdit==i-1) evenNums.Add(input[i+1]);
        else
        {
            evenNums.Add(input[i]);
            evenNums.Add(input[i+1]);
            lastEdit = i;
        }
    }
}
int sum = evenNums.Sum();

Console.WriteLine(sum);
