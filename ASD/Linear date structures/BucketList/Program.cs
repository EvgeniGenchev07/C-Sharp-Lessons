using BucketList;
BucketList<int> n = new BucketList<int>();
for (int i = 1; i < 40; i++)
{
    n.Add(i);
}
n.Remove(0);
n.Remove(3);
//foreach (int i in n) { Console.WriteLine(i); }

n.Insert(1, 2);
//foreach (int i in n) { Console.WriteLine(i); }
foreach (int i in n) { Console.WriteLine(i); }