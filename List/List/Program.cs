List<int> number = new List<int>();
number.Add(20);
number.Add(30);
number.Add(40);
number.RemoveAt(1); // Удаление элемента по индексу
number.Remove(40); // Удаление элемента по значению.
number.Clear(); // Удаление всего из списка
number.AddRange(new int[] { 1, 2, 3 }); //Добавление значений массива в лист
Console.WriteLine("index = " + number.IndexOf(3));// Индекс элемента по его значению
Console.WriteLine(number.Count); // Длина листа
number.Insert(1, 123123);
for (int i = 0; i < number.Count; i++) // Вывод всех эдементов листа
{
    Console.WriteLine(number[i]);
}
