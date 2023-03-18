/* Задача 3: Задайте двумерный массив. Найдите сумму элементов
главной диагонали. */



Console.Write("Сколько строк в массиве ___");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Сколько column в массиве ___");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Min в массиве ___");
int min = int.Parse(Console.ReadLine()!);
Console.Write("max в массиве ___");
int max = int.Parse(Console.ReadLine()!);


int[,] FillArray(int rowArray, int colArray, int start, int end)
{
    int[,] arr = new int[rowArray, colArray];
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < colArray; j++)
        {
            arr[i, j] = new Random().Next(start, end);
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }

}


int FindSuumDiagonal(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int summ = 0;
    if (col == row)
    {
        for (int i = 0; i < row; i++)
        {
             summ = summ + array[i, i];
              Console.Write($"{array[i, i]} + ");
        }
    }
    return summ;
}


int[,] massiv = FillArray(row, col, min, max);
PrintArray(massiv);
Console.WriteLine("---");
int res = FindSuumDiagonal(massiv);
Console.WriteLine($" = {res}");

