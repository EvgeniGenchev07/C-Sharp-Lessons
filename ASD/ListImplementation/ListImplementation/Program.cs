using ListImplementation;

var a = new CustomStaticList<int>();
a.Add(1);
a.Add(2);
var ar = new[] { 4, 5, 6 };
a.CopyTo(ar);
Console.WriteLine(string.Join(", ",ar));
for (int i = 0; i < a.Count; i++)
{
    Console.WriteLine(a[i]);
}
