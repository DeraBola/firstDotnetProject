int hero = 10;
int enemy = 10;
Random punches = new();

do
{
   int heroPunches = punches.Next(1, 11);
    enemy -= heroPunches;
    Console.WriteLine($"Monster was damaged and lost {heroPunches} health and now has {enemy} health.");

    int enemyPunches = punches.Next(1, 11);
    hero -= enemyPunches;
    Console.WriteLine($"Hero was damaged and lost {enemyPunches} health and now has {hero} health.");
} while (hero > 0 && enemy > 0);

Console.WriteLine(hero > enemy ? "Hero wins!" : "Monster wins!");