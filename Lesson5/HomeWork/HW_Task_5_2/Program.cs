// Задача 2: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.

Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите меншее значение в массиве_");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее значение в массиве_");
int to = int.Parse(Console.ReadLine()!);

double[] FullArray(int Len, int Start, int End)
{
    double[] arr = new double[Len];
    for (int i = 0; i < Len; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * Start * End, 2);  //   Next(Start, End);
    }
    return arr;
}

void PrintArr(double[] Array)
{
    int len = Array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{Array[i]} ");
    }
}

double FindInArray(double[] Array)
{
    int len = Array.Length;
    double summ = 0;
    for (int i = 0; i < len; i++)
    {
        if (i % 2 == 0)
        {
            summ = summ + Array[i];
            Console.Write($"{Array[i]} + ");
        }
    }
    Console.Write($"={summ}");
    return summ;
}

double[] massiv = FullArray(Size, from, to);
PrintArr(massiv);
Console.WriteLine();
FindInArray(massiv);
