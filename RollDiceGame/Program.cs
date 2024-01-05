Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"You rolled dice: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled double! +2 bonus to total");
    total += 2;
}
if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triple! +6 bonus to total");
    total += 6;
}

Console.WriteLine($"Your total: {total}");

if (total > 15)
{
    Console.WriteLine("You Win.");
    
}
if (total < 15)
{
    Console.WriteLine("You Lose.");
}