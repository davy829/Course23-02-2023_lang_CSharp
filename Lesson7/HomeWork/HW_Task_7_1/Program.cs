// Задача 1: Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

Console.Write("Введите высоту массива_");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите ширину массива_");
int col = int.Parse(Console.ReadLine()!);

int[,] FullArray(int ArrRow, int ArrCol)
{
    int[,] tmpArray = new int[ArrRow, ArrCol];

    for (int i = 0; i < ArrRow; i++)
    {
        for (int j = 0; j < ArrCol; j++)
        {
            int value = new Random().Next(-99, 99);
            tmpArray[i, j] = value;
        }
    }
    return tmpArray;
}

void PrintArray(int[,] tmpArray)
{
    int rowArray = tmpArray.GetLength(0);
    int colArray = tmpArray.GetLength(1);
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < colArray; j++)
        {
            Console.Write($"{tmpArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] MyArray = FullArray(row, col);
PrintArray(MyArray);