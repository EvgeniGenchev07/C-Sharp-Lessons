using Task1;

DynamicStack<int> nums =  new DynamicStack<int>(0);
nums.Push(1);
nums.Push(2);
nums.Push(4);
nums.Push(5);
nums.Push(6);
Console.WriteLine(nums.Peek());
Console.WriteLine(nums.Pop());
Console.WriteLine(nums.Pop());
Console.WriteLine(nums.Pop());
Console.WriteLine(nums.Pop());
Console.WriteLine(nums.Pop());
Console.WriteLine("----");
Console.WriteLine(nums.Count);
Console.WriteLine("----");
Console.WriteLine(nums.Pop());

