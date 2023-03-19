string[,] books =
{
    {"Пушкин", "Лермонтов","Есенин" },
    {"Робер Мартин", "Джесси Шелл","Роберт Тепляков" },
    {"Стивен Кинг", "Говард Лавкрафт","Ерем Стокер" },
};
bool isOpen = true;


while (isOpen)
{
    Console.SetCursorPosition(0, 20);
    Console.WriteLine("Все авторы\n");
    for (int i = 0; i < books.GetLength(0); i++)
    {
        for (int a = 0; a < books.GetLength(1); a++)
        {
            Console.Write(books[i, a] + " | ");
        }
        Console.WriteLine();
    }
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Библиотека");
    Console.WriteLine("1 - Узнать имя автора по индексу книги");
    Console.WriteLine("2 - Найти книгу по автору");
    Console.WriteLine("3 - Выход из программы");
    Console.WriteLine("Выберите пункт меню");
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            int line, column;
            Console.WriteLine("Введите номер полки");
            line = Convert.ToInt32(Console.ReadLine()) - 1;
            if (line > books.GetLength(0) || line < 0)
            {
                Console.WriteLine("Полок меньше чем вы ввели");
                break;
            }
            Console.WriteLine("Введите номер книги");
            column = Convert.ToInt32(Console.ReadLine()) - 1 ;
            if (column > books.GetLength(1) || column < 0)
            {
                Console.WriteLine("Книг меньше чем вы ввели");
                break;
            }
            Console.WriteLine(books[line,column]);
            break;
        case 2:
            string author;
            bool authorIsFind = false;
            Console.WriteLine("Введите своего автора");
            author = Console.ReadLine().ToLower();
            for (int i = 0; i < books.GetLength(0); i++)
            {
                for (int t = 0; t < books.GetLength(1); t++)
                {
                    if(books[i,t].ToLower() == author)
                    {
                        authorIsFind = true;
                        Console.WriteLine("Номер полки: " + (i + 1) + " " + "Номер столбца: " + (t + 1));
                        break;
                    }
                }
            }
            if(authorIsFind == false)
            {
                Console.WriteLine("АВТОР НЕ НАЙДЕН");
            }
            break;
        case 3:
            isOpen = false;
            break;
        default:
            Console.WriteLine("Неверная команда");
            break;
    }
    if (isOpen)
    {
        Console.WriteLine("Нажмите клавишу для продолжения");
    }
    Console.ReadKey();
    Console.Clear();
}
