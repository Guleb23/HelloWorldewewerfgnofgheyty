int health = 5, maxHealth = 10;
int mana = 7, maxMana = 20;
while (true)
{

    DrowBar(health, maxHealth, ConsoleColor.Green, symbol: '|');
    DrowBar(mana, maxMana, ConsoleColor.Blue, 1);


    Console.SetCursorPosition(0, 7);
    Console.Write("Число на которое измениться здоровье: ");
    health += Convert.ToInt32(Console.ReadLine());  
    Console.Write("Число на которое измениться мана: ");
    mana += Convert.ToInt32(Console.ReadLine());   

    Console.ReadKey();
    Console.Clear();
}



static void DrowBar(int value, int maxValue, ConsoleColor color, int position = 0, char symbol = '_')
{
    ConsoleColor defaultColor = Console.BackgroundColor;
    string bar = "";
    for (int i = 0; i < value; i++) // Отображаем текущее здоровье
    {
        bar += symbol;
    }

    Console.SetCursorPosition(0, position);
    Console.Write("{");
    Console.BackgroundColor = color;
    Console.Write(bar);
    Console.BackgroundColor = defaultColor;
    bar = "";
    for (int i = value; i < maxValue; i++)// Отображаем здоровье, которого не хватает до полного
    {
        bar += symbol;
    }
    Console.Write(bar);
    Console.Write('}');
}