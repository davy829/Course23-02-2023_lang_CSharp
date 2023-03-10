// Задача 2: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.

Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите меншее значение в массиве_");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее значение в массиве_");
int to = int.Parse(Console.ReadLine()!);

int[] FullArray(int Len, int Start, int End)
{
    int[] arr = new int[Len];
    for (int i = 0; i < Len; i++)
    {
        arr[i] = new Random().Next(Start, End);
    }
    return arr;
}

void PrintArr(int[] Array)
{
    int len = Array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{Array[i]} ");
    }
}

int FindInArray(int[] Array)
{
    int len = Array.Length;
    int summ = 0;
    for (int i = 0; i < len; i++)
    {
        if (i % 2 == 1)
        {
            summ = summ + Array[i];
         Console.Write($"{Array[i]} + ");   
        }
    }
    Console.Write($"={summ}");
    return summ;
}

int[] massiv = FullArray(Size, from, to);
PrintArr(massiv);
Console.WriteLine();
FindInArray(massiv);
