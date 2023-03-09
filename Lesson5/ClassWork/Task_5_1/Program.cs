// Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите меншее значение в массиве_");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее значение в массиве_");
int to = int.Parse(Console.ReadLine()!);


int[] FullArray(int len, int start1, int end1)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(start1, end1);
    }
    return arr;
}
void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void RestoreArr(int[] arr5)
{
    for (int i = 0; i < arr5.Length; i++)
    {
        arr5[i] = arr5[i] * -1;
    }
}

int[] massiv = FullArray(Size, from, to);
PrintArr(massiv);
Console.WriteLine();
RestoreArr(massiv);
PrintArr(massiv);


