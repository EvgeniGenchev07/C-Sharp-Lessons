using Sort_Algorithms;

//-10 -35 8 125 37 8 -10 -54 3
//-3 9 5 -7 6 -9 -4 2
//100 20 52 14 65 20 15 20 12
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
nums.Quick(nums.Length-1,nums.Length-1);
Console.WriteLine(string.Join(", ",nums));