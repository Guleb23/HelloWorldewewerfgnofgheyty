Console.CursorVisible = false;
bool onPlay = true;
int userX = 6;
int userY = 6;
char[] bag = new char[1];
char[,] map = new char[18, 18]
{
    {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
    {'#',' ','#',' ',' ',' ',' ','#','X',' ','#',' ',' ',' ','X',' ',' ','#' },
    {'#',' ','#',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ','#',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ','#',' ',' ',' ',' ','#','#',' ','#',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ','#','#','#','#','#','#',' ',' ',' ',' ',' ','X',' ',' ',' ','#' },
    {'#',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ','#','X',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
};
while (onPlay)
{
    Console.SetCursorPosition(0, 20);
    Console.Write("Сумка:");
    for (int i = 0; i < bag.Length; i++)
    {
        Console.Write(bag[i] + " ");
    }
    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int d = 0; d < map.GetLength(1); d++)
        {
            Console.Write(map[i, d]);
        }
        Console.WriteLine();
    }

    Console.SetCursorPosition(userY, userX);
    Console.Write('@');
    ConsoleKeyInfo charKey = Console.ReadKey();
    switch (charKey.Key)
    {
        case ConsoleKey.UpArrow:
            if (map[userX - 1, userY] != '#')
            {
                userX--;
            }
            break;
        case ConsoleKey.DownArrow:
            if (map[userX + 1, userY] != '#')
            {
                userX++;
            }
            break;
        case ConsoleKey.LeftArrow:
            if (map[userX, userY - 1] != '#')
            {
                userY--;
            }
            break;
        case ConsoleKey.RightArrow:
            if (map[userX, userY + 1] != '#')
            {
                userY++;
            }
            break;
    }
    if (map[userX, userY] == 'X')
    {
        map[userX, userY] = 'O';
        char[] tempBag = new char[bag.Length + 1];
        for (int i = 0; i < bag.Length; i++)
        {
            tempBag[i] = bag[i];
        }
        tempBag[tempBag.Length - 1] = 'X';
        bag = tempBag;

    }
    Console.Clear();
}
