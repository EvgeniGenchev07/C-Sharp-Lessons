using _2_;

var brands = new List<Brand>();
var foods = new List<Food>();
var kinder = new Brand()
{
    Name = "Kinder",
    Id = 1,
    Email = "office@kinder.com",
    Foods = new List<Food>()
};
brands.Add(kinder);
var delice = new Food()
{
    Name = "Delice",
    Barcode = "134243242",
    Brand = kinder,
    Price = 11,
    Quantity = 3
};
foods.Add(delice);
kinder.Foods.Add(delice);
foods.Where(f => f.Price > 10)
    .ToList()
    .ForEach(f => Console.WriteLine(f.ToString()));
foods.Where(f => f.Price > 10)
    .ToList()
    .ForEach(f => Console.WriteLine(string.Join(", ", f.Name)));
foods.ForEach(f => Console.WriteLine($"{f.Name} - {f.Price * f.Quantity}"));
Console.WriteLine(foods.Sum(f => f.Price * f.Quantity));
foods.Where(f => f.Quantity <= 10)
    .Select(f => f.Price += f.Price * 0.1)
    .ToList()
    .ForEach(f => Console.WriteLine(f.ToString()));
Console.WriteLine(foods.Where(f => f.Name[0] == 'A').Count());
Console.WriteLine(foods.Where(f => f.Brand.Id == 1).Count());
brands.ForEach(b => Console.WriteLine($"{b.Name} - {b.Foods.Count()}"));
foods.OrderBy(f => f.Quantity)
    .ThenByDescending(f => f.Price)
    .ToList()
    .ForEach(f => Console.WriteLine(f.ToString()));
