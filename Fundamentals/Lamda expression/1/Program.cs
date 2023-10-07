var random = new Random();
var n = random.Next(10, 20);
var numbers = new List<int>();
for (int i = 0; i <= n; i++)
{
    var num = random.Next(-1000, 1000);
    numbers.Add(num);
}
var positives = numbers.Where(x => x > 0).ToList();
Console.WriteLine(string.Join(", ", positives));
var predicate = numbers.Any(x => x < 0);
Console.WriteLine(predicate);
var sum = numbers.Where(x => x < 0).Sum();
Console.WriteLine(sum);
var evens = numbers.Where(x => x % 2 == 0 && x > 20).Count();
Console.WriteLine(evens);
var orderedNums = numbers.OrderByDescending(x => x).ToList();
Console.WriteLine(string.Join(", ", orderedNums));