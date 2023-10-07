string str = Console.ReadLine();
FindMatches(str, str.Length - 1, new List<int>());
static void FindMatches(string str, int index, List<int> f)
{
    if (index < 0) return;
    if (')' == str[index]) f.Add(index);
    else if ('(' == str[index])
    {
        Console.WriteLine(str.Substring(index, f[f.Count - 1] - index + 1));
        f.RemoveAt(f.Count - 1);
    }
    FindMatches(str, index - 1, f);
}
