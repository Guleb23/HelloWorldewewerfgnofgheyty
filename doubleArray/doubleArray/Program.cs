int[,] arr;
int[,] arr2 = new int[3, 2];
int[,] arr3 =
{
    {1, 2, 3, 4},
    {1, 2, 3, 2}
};
//Инициализируем массив с указанием размера
int[,] arr4 = new int[3, 4]
{
    {1, 1, 1, 1}, //0
    {1, 1, 9, 1}, //1
    {1, 1, 1, 1}  //2
};
//Перебор массива
for (int i = 0; i < arr4.GetLength(0); i++) // Перебирает строки
{
    for (int d = 0; d < arr4.GetLength(1); d++) // Перебирает значения
    {
        Console.Write(arr4[i,d] + " ");//i будет указывать на номер строки, а d на номер элемента, + " " нужно для того чтобы после каждого элемента стоял пробел
    }
    Console.WriteLine(); // нужно чтобы каждая новая сторока массива появлялась на новой строчке
}

//Рандомный двумерный массив значений
int[,] randArr = new int[4, 4];
Random rand = new Random();
for (int i = 0; i < randArr.GetLength(0); i++)
{
    for (int r = 0; r < randArr.GetLength(1); r++)
    {
        randArr[i, r] = rand.Next(0, 101);
        Console.Write(randArr[i, r] + " ");
    }
    Console.WriteLine();
}
