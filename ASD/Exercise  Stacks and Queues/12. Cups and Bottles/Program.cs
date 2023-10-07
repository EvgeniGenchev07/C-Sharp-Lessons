int[] inputCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] inputBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> bottles = new Stack<int>();
Queue<int> cups = new Queue<int>();
for (int i = 0; i < inputCups.Length; i++)
{
    cups.Enqueue(inputCups[i]);
}
for (int i = 0; i < inputBottles.Length; i++)
{
    bottles.Push(inputBottles[i]);
}
int cup = cups.Dequeue();
int waste = 0;
while ((cup > 0 || cups.Count > 0) && bottles.Count > 0)
{
    int bottle = bottles.Pop();
    cup -= bottle;
    if (cup <= 0)
    {
        waste += Math.Abs(cup);
        if (bottles.Count != 0&& cups.Count != 0) cup = cups.Dequeue();
    }
}
if (cups.Count != 0)
{
    Console.WriteLine("Cups: {0}", string.Join(" ", cups));
}
else if (bottles.Count != 0)
{
    Console.WriteLine("Bottles: {0}", string.Join(" ", bottles));
}
Console.WriteLine("Wasted litters of water: {0}", waste);
