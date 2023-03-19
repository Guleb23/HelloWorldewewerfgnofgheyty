int[] arr = new int[5] { 1, 300, 2, 7, 8 };
int maxValue = int.MinValue;
for (int i = 0; i < arr.Length; i++)
{
    if (maxValue < arr[i])
    {
        maxValue = arr[i];
    }
}
Console.WriteLine(maxValue);
//Поиск максимального элемена в массиве
