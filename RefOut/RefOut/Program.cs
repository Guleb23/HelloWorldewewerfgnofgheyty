/*static void Add(out int sum, int x, int y)
{
    sum = x + y;
}
int  sum, x = 1, y = 5;
Add(out sum, x, y);
Console.WriteLine(sum);*/
int[] arr = new int[5];
arr = EditArr(arr, 2, 5);
Console.WriteLine(arr[2]);
static int[] EditArr(int[]array,int index, int value)//Увеличение массива размера
{
    array = new int[8];
    array[index] = value;
    return array;
}
