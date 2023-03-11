// Задача 1: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.

Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите меншее значение в массиве_");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее значение в массиве_");
int to = int.Parse(Console.ReadLine()!);

int[] FullArray(int len, int from, int to)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
       Console.Write($"{arr[i]} ");
    }
}

void FindPositiv(int[] myarr)
{
    int len=myarr.Length;
    int count=0;
    for (int i = 0; i < len; i++)
    {
       if( myarr[i] % 2 == 0)
       count++;
    }
    Console.WriteLine();
    Console.WriteLine($" Positive numbers : {count}");
}


int[] mass = FullArray(Size, from, to);
PrintArray(mass);
FindPositiv(mass);