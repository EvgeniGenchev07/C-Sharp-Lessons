using SingleLinkedList;

var a = new SingleLinkedList<int>();
a.Add(1);
a.Add(2);
a.Add(3);
a.Add(4);
a.Add(5);
a.InsertAt(2, 1);
a.InsertAt(3, 6);
a.RemoveAt(0);
a.Reverse();
a.Print();
int[] ar = new int[]{ 1, 2, 34, 5, 6, 7, 8 };
a.CopyTo(ar, 1);
Console.WriteLine(string.Join(", ",ar));