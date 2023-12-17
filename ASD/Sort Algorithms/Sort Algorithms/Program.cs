using Sort_Algorithms;

//-10 -35 8 125 37 8 -10 -54 3
//54 56 20 12 30 84 56 98 -9 -65 -4 -3 -12
//-3 9 5 -7 6 -9 -4 2
//100 20 52 14 65 20 15 20 12
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
nums.QuickSort();
Console.WriteLine(string.Join(", ",nums));
int num = int.Parse(Console.ReadLine());
Console.WriteLine(nums.BinarySearch(num));