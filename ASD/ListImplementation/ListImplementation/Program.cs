using ListImplementation;

var a = new CustomStaticList<int>();
a.Add(1);
a.Add(2);
a.Add(4);
a.Add(3);
a.AddRange(new int[] {4,5,6});
a.Remove(3);
a.RemoveAt(1);
var b = new int[3];
a.CopyTo(1, b, 0, 3);
for (int i = 0; i < b.Length; i++)
{
    Console.WriteLine(b[i]);

}
a.Add(2);
a.Reverse();
Console.WriteLine( a.IndexOf(4));
Console.WriteLine( a.LastIndexOf(4));
Console.WriteLine( a.Contains(2));
for (int i = 0; i < a.Count; i++)
{
    Console.WriteLine(a[i]);
}
Console.WriteLine( a.Count);
Console.WriteLine(a.Capacity);