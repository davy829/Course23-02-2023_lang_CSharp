// Задача 1: Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

Console.Write("Введите высоту массива_");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите ширину массива_");
int col = int.Parse(Console.ReadLine()!);

double[,] FullArray(int ArrRow, int ArrCol)
{
    double[,] tmpArray = new double[ArrRow, ArrCol];

    for (int i = 0; i < ArrRow; i++)
    {
        for (int j = 0; j < ArrCol; j++)
        {
            double value = Math.Round(new Random().NextDouble() * 2.9, 3);
            tmpArray[i, j] = value;
        }
    }
    return tmpArray;
}

void PrintArray(double[,] tmpArray)
{
    int rowArray = tmpArray.GetLength(0);
    int colArray = tmpArray.GetLength(1);
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < colArray; j++)
        {
            Console.Write($"{tmpArray[i, j]}\t  ");
        }
        Console.WriteLine();
    }
}

double[,] MyArray = FullArray(row, col);
PrintArray(MyArray);