using Stack_and_Queue;
using StaticStack;

var a = new DynamicStack<int>();
a.Push(1);
a.Push(2);
a.Push(3);
a.Push(4);
a.Push(5);
Console.WriteLine( a.Contains(5));
Console.WriteLine( a.Pop());
Console.WriteLine(a.Contains(5));
Console.WriteLine( a.Peek());
var ar = new int[] { 0, 6, 6, 6, 6, 6, 6, 7 };
a.CopyTo(ar, 1);
Console.WriteLine(string.Join(", ", ar));
a.Reverse();
//a.Print();
var c = 4;
for (int i = 0; i < c; i++)
{
    Console.WriteLine(a.Count);
    Console.WriteLine(a.Pop());
}