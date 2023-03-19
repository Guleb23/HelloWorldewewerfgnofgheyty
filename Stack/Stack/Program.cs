Stack<int> num = new Stack<int>();
num.Push(12); // Добавление элемента в коллекцию
num.Push(32);
num.Push(112);
Console.WriteLine(num.Pop() ); // Возвращает последний(первый) элемент  в коллекции, а затем удаляет его из коллекции
Console.WriteLine(num.Peek() ); // Возвращает последний(первый) элемент  в коллекции
foreach (int number in num)
{
    Console.WriteLine(number);
}
