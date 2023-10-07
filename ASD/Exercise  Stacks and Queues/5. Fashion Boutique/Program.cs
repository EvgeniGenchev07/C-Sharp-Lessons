int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rack = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();
for (int i = 0; i < nums.Length; i++)
{
    stack.Push(nums[i]);
}
int sum = 0;
int racks = 0;

while (stack.Count>0)
{
    int num = stack.Pop();
    sum+= num;
    if (sum > rack)
    {
        racks++;
        sum = num;
    }
    else if (sum == rack)
    {
        racks++;
        sum = 0;
    }
    
}
if (sum != 0) racks++;
Console.WriteLine(racks);
