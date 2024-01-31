string[] scores = {"B12", "B10", "A2", "A1", "B11", "A10", "A12", "B1", "B13", "A11"};
Array.Sort(scores);
foreach (string score in scores)
{
    Console.WriteLine($"-- {score}");
}
Console.WriteLine($"-- ------------------");
Array.Reverse(scores);

foreach (string score in scores)
{
    Console.WriteLine($"-- {score}");
}

Console.WriteLine($"-- ------------------");
Array.Clear(scores,0,8);
foreach (string score in scores)
{
    Console.WriteLine($"-- {score}");
}
Console.WriteLine($"-- ------------------");
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]?.ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]?.ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Resize(ref pallets, 8);
Console.WriteLine($"-- ------------------");

pallets[7]= "abc";
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Resize(ref pallets,2);
;
Console.WriteLine($"-- ------------------");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
