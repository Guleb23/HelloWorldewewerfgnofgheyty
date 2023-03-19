int[] box = new int[2] {1,2};
int[] tempBox = new int[box.Length + 1];
for (int i = 0;i < box.Length; i++)
{
    tempBox[i] = box[i];
    Console.WriteLine(tempBox[i]);
}
