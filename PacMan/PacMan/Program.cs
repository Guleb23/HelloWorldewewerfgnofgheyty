using System.IO; // Нужно чтобы использовать методы работы с файлами(File)
using System.Threading; //Нужна чтобы пакман двигался всегда в какую-то сторону(исполбзуя многопоточность)
internal class Program
{
    private static void Main(string[] args)
    {
        Console.CursorVisible = false;
        char[,] map = ReadAllMap("map.txt");
        ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

        Task.Run(() => // Этот блок нужен, чтобы нажатие кнопки обрабатывалось само необходимо для самостоятельного движения пакмена
        {
            while (true)
            {
                pressedKey = Console.ReadKey();
            }

        });

        int positioX = 1;
        int positioY = 1;
        int score = 0;
        while (true)
        {

            Console.Clear();

            HandleInput(map, pressedKey, ref positioX, ref positioY, ref score);

            Console.ForegroundColor = ConsoleColor.Blue;
            DrowMap(map);

            Console.SetCursorPosition(positioX, positioY);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write('@');

            Console.SetCursorPosition(30, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Вы набрали : {score}  очков");

            Thread.Sleep(200); // скорость движения пакмена(милисекунды)
        }
    }
    private static char[,] ReadAllMap(string path) // Функция которая считывает карту из текстового файла (параметром является путь к файлу)
    {
        string[] file = File.ReadAllLines(path); // Метод, который считывает массив строк из файла
        char[,] map = new char[file.Length, GetMaxLength(file)]; // Создаем массив, размером по х как длинна строки массива выше, а высоту как длину всего массива
        for (int y = 0; y < map.GetLength(0); y++) // Циклы с помощью которых мы приравниваем значения файлового массива, значения нашего двумерного массива
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                map[y, x] = file[y][x];
            }
        }
        return map;
    }

    private static int GetMaxLength(string[] lines) //Функция нахождения максимального размера карты по ширине
    {
        int maxLength = lines[0].Length;
        foreach (var item in lines)
        {
            if (lines.Length > maxLength)
            {
                maxLength = lines.Length;
            }

        }
        return maxLength;
    }
    private static void DrowMap(char[,] map) // Функция отрисовки двумерного массива(Карты)
    {
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                Console.Write(map[y, x]);
            }
            Console.WriteLine();
        }
    }

    private static void HandleInput(char[,] map, ConsoleKeyInfo pressedKey, ref int positionX, ref int positionY, ref int score) // функция передвижения
    {
        int[] direction = GetDirection(pressedKey);
        int nextPositionX = positionX + direction[0];
        int nextPositionY = positionY + direction[1];
        char nextCell = map[nextPositionY, nextPositionX];// Следующий символ
        if (nextCell == ' ' || nextCell == '*')
        {
            positionX = nextPositionX;
            positionY = nextPositionY;
            if (nextCell == '*')
            {
                score++;
                map[positionY, positionX] = ' ';
            }
        }

    }

    private static int[] GetDirection(ConsoleKeyInfo pressedKey) // Метод определения в каком векторе мы находимся
    {
        int[] direcion = { 0, 0 };
        if (pressedKey.Key == ConsoleKey.UpArrow)
        {
            direcion[1] = -1;
        }
        else if (pressedKey.Key == ConsoleKey.DownArrow)
        {
            direcion[1] = 1;
        }
        else if (pressedKey.Key == ConsoleKey.RightArrow)
        {
            direcion[0] = 1;
        }
        else if (pressedKey.Key == ConsoleKey.LeftArrow)
        {
            direcion[0] = -1;
        }
        return direcion;
    }
}