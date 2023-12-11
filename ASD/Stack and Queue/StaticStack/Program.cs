using Stack_and_Queue;
using StaticStack;

//var a = new StaticStack<int>();
//a.Push(1);
//a.Push(2);
//a.Push(3);
//a.Push(4);
//a.Push(5);
//Console.WriteLine( a.Contains(5));
//Console.WriteLine( a.Pop());
//Console.WriteLine(a.Contains(5));
//Console.WriteLine( a.Peek());
//var ar = new int[] { 0, 6, 6, 6, 6, 6, 6, 7 };
//a.CopyTo(ar, 1);
//Console.WriteLine(string.Join(", ", ar));
//a.Reverse();
////a.Print();
//var c = 4;
//for (int i = 0; i < c; i++)
//{
//    Console.WriteLine(a.Count);
//    Console.WriteLine(a.Pop());
//}

//var a = new DynamicStack<int>();
//a.Push(1);
//a.Push(2);
//a.Push(3);
//a.Push(4);
//a.Push(5);
//Console.WriteLine(a.Contains(5));
//Console.WriteLine(a.Pop());
//Console.WriteLine(a.Contains(5));
//Console.WriteLine(a.Peek());
//var ar = new int[] { 0, 6, 6, 6, 6, 6, 6, 7 };
//a.CopyTo(ar, 1);
//Console.WriteLine(string.Join(", ", ar));
//a.Reverse();
//a.Print();

//var a = new DynamicQueue<int>();
//a.Enqueue(1);
//a.Enqueue(2);
//a.Enqueue(3);
//a.Enqueue(4);
//a.Enqueue(5);
//a.Enqueue(6);
//a.Dequeue();
//a.Dequeue();
//Console.WriteLine(a.Peek());
//Console.WriteLine(a.Contains(2)); 
//Console.WriteLine(a.Contains(5));
//var ar = new int[] { 0, 6, 6, 6, 6, 6, 6, 7 };
//a.CopyTo(ar, 1);
//Console.WriteLine(string.Join(", ", ar));
//a.Reverse();
//a.Print();

var a = new StaticQueue<int>();
a.Enqueue(1);
a.Enqueue(2);
a.Enqueue(3);
a.Enqueue(4);
a.Enqueue(5);
a.Enqueue(6);
a.Dequeue();
a.Dequeue();
Console.WriteLine(a.Peek());
Console.WriteLine(a.Contains(2));
Console.WriteLine(a.Contains(5));
var ar = new int[] { 0, 6, 6, 6, 6, 6, 6, 7 };
a.CopyTo(ar, 1);
Console.WriteLine(string.Join(", ", ar));
a.Reverse();
int c = 4;
a.Clear();
for (int i = 0; i < c; i++)
{
    Console.WriteLine(a.Dequeue());
}