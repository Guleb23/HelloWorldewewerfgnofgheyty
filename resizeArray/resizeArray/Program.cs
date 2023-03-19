
internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[5];
        int[,] doubArr = new int[2, 2];
        arr = Resize(arr, 10);
        doubArr = Resize(doubArr, 10, 10);
        Console.WriteLine(arr.Length);
        Console.WriteLine(doubArr.Length);

        
    }
    static int[] Resize(int[] arr, int length) // функция перезаписи размера одномерного массива
    {
        int[] tempArr = new int[length];
        for (int i = 0; i < arr.Length; i++)
        {
            tempArr[i] = arr[i];
        }
        arr = tempArr;
        return arr;
    }


    static int[,] Resize(int[,] array, int x, int y) // функция перезаписи размера двумерного массива
    {
        int[,] tempArr = new int[x, y];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int d = 0; d < array.GetLength(1); d++)
            {
                tempArr[i, d] = array[i, d];
            }
        }
        array = tempArr;
        return array;
    }
}