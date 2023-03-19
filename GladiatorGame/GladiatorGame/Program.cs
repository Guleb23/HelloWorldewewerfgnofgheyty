Random rand = new Random();

float helth1 = rand.Next(90, 100);
float helth2 = rand.Next(80, 150);
int damage1 = rand.Next(5, 20),
    damage2 = rand.Next(20, 40);
int armor1 = rand.Next(25, 65),
    armor2 = rand.Next(65, 100);
Console.WriteLine($"Первый гладиатор имеет характеристики: Здоровье:{helth1}, Урон: {damage1}, Броню: {armor1}");
Console.WriteLine($"Второй гладиатор имеет характеристики: Здоровье:{helth2}, Урон: {damage2}, Броню: {armor2}");
while (helth1 > 0 && helth2 > 0)
{
    helth1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
    helth2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;
    Console.WriteLine($"Первый гладиатор имеет Здоровье:{helth1}");
    Console.WriteLine($"Второй гладиатор имеет Здоровье:{helth2}");
}
if (helth1 <= 0 && helth2 <= 0)
{
    Console.WriteLine("Ничья");
}
else if (helth1 <= 0)
{
    Console.WriteLine("First dead");
}
else if (helth2 <= 0)
{
    Console.WriteLine("SECOND dead");
}

