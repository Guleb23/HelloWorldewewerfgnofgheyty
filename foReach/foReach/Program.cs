string line = "hello"; // Можно обращаться к любой строке как к массиву, но нельзя перезаписывать значения
Console.WriteLine(line[3]);
int[] num = new int[3] {1,2,3};
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine(num[i]);
}
foreach (int i in num)
{
    Console.Write(i + 2);
}
