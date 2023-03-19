int[] seats = { 6, 28, 15, 15, 17 };
bool isOpen = true;

while (isOpen) //Нужно чтобы мы оптсоянно видели программу и сами могли ее выключить при помощи переменной isOpen
{

    //Показывем сколько всего мест(Выводим значение массива)
    Console.SetCursorPosition(0, 20);
    for (int i = 0; i < seats.Length; i++)
    {
        Console.WriteLine($" В секторе {i + 1} свободно {seats[i]} мест");
    }
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Регистрация рейса");
    Console.WriteLine("\n1 - Забронировать места\n2 - Выйти из программы");
    Console.WriteLine("Введите номер команды");

    //Настравиваем работу с пользователем
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            int userSector, userPlaseAmount;
            Console.WriteLine("В каком секторе вам нужно место?");
            userSector = Convert.ToInt32(Console.ReadLine()) - 1; // В каком секторе нужно место(т.е на каком индексе массива)
            if (seats.Length <= userSector || userSector < 0)
            {
                Console.WriteLine("Некорректно введены данные");
                break;
            }
            Console.WriteLine("Сколько мест вы хотите забронировать?");
            userPlaseAmount = Convert.ToInt32(Console.ReadLine()); // сколько нужно мест(т.е мы уже смотрим на значения массива)
            if (seats[userSector] < userPlaseAmount || userPlaseAmount < 0)
            {
                Console.WriteLine($"Некорректно введены данные, в секторе {userSector} - {seats[userSector]} мест");
                break;
            }
            seats[userSector] -= userPlaseAmount ;
            break;
        case 2:
            isOpen= false; //Выход из программы
            break;
    }

    Console.ReadKey();
    Console.Clear();

}
