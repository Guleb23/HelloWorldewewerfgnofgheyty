Console.WriteLine("Hello");
Console.WriteLine("You here?");
writeError("You disconnect", ConsoleColor.Red);
Console.WriteLine("Wow!!!");
writeError("Wtf@!", ConsoleColor.Green, symbol:'2') ; // Обращение к следующему необязательному параметру, не изменяя тот, что между ними (color)
static void writeError( string text, ConsoleColor color = ConsoleColor.Red, char symbol = '@') //Функция с передаваемым значением(С необязательным параметром ConsoleColor, если не введешь аргумент сам, то будет Red)
{
    ConsoleColor defaultColor = Console.ForegroundColor;
    Console.ForegroundColor = color;
    Console.WriteLine(text + symbol);
    Console.ForegroundColor = defaultColor;
}  
static int Sum(int x, int y)
{
    int sum =  x + y;
    return sum;
}
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int sum = Sum(x, y);
Console.WriteLine(sum);