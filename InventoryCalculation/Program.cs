int[] inventory = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
int total = 0;
int bin = 0;
foreach(int items in inventory)
{
    total += items;
    bin++;
    Console.WriteLine($"Bin {bin} : {items} items (total running={total})");
}