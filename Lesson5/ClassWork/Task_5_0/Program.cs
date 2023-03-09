// See https://aka.ms/new-console-template for more information
Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите меншее значение в массиве_");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее значение в массиве_");
int to = int.Parse(Console.ReadLine()!);

int[] FullArray(int Len, int Start1, int End1)
{
    int[] arr = new int[Len];
    for (int i = 0; i < Len; i++)
    {
        arr[i] = new Random().Next(Start1, End1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(); 
}

void SummNegativPositve(int[] arr)
{
    int len = arr.Length;
    int summPos = 0;
    int summNeg = 0;
    for (int i = 0; i < len; i++)
    {
        if (arr[i] > 0)
        {
            summPos = summPos + arr[i];
        }
        else
            summNeg = summNeg + arr[i];
    }
    Console.WriteLine($"сумма положительных значений в массиве -> {summPos}");
    Console.WriteLine($"сумма отриц. значений в массиве -> {summNeg}");
}

int[] massiv = FullArray(Size, from, to);
PrintArray(massiv);
SummNegativPositve(massiv);
