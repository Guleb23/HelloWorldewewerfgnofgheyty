int[] arr = new int[3];
int[] arr2 = new int[5];
arr = arr2;// Теперь два массива ссылаются на одну область в памяти
arr[0] = 20;
Console.WriteLine(arr2[0]);