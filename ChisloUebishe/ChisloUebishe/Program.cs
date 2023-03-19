int num;
int lower, upper;
Console.Write("Введи нижнюю границу числа:");
lower = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи верхнюю границу числа:");
upper = Convert.ToInt32(Console.ReadLine());
int userTries = 5;
Console.WriteLine($" Попробуй угадать число, количество твоих попыток:{userTries}");
int userInput;
Random rand = new Random();
num = rand.Next(lower, (upper - 1));
for(int i = (userTries-1); i >= 0; --i)
{
    userInput= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Ваш вариант:{userInput}");
    if (userInput == num)
    {
        Console.WriteLine($"Congritulation!!! Вы правы это число:{num}");
        break;
    }
    else
    {
        Console.WriteLine($" Попробуй угадать число, количество твоих попыток:{i}");
        if (i <= 0)
        {
            Console.WriteLine($"Позор у тебя {i} попыток");
        }
       
    }
    if (i <= 0)
    {
        Console.WriteLine($"Число: {num} ");
    }

}
