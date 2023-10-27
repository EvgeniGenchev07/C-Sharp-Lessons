using ListImplementation;

var a = new CustomStaticList<int>();
a.Add(1);
a.Add(2);
a.Add(4);
a.Add(3);
a.Add(3);
a.Add(3);
a.Remove(3);
a.RemoveAt(1);
a.InsertAt(0, 0);
a.InsertAt(0, 1);
a.CopyTo(5,new[] {4,5,6},0,3);
Console.WriteLine(  a.Capacity);
for (int i = 0; i < a.Count; i++)
{
    Console.WriteLine(a[i]);
}
