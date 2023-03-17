/* //Задача 1: Задайте двумерный массив размера m на n, каждый
элемент в массиве находится по формуле: Aₙₙ = m+n.
Выведите полученный массив на экран. */


Console.Write("Сколько строк в массиве ___");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Сколько column в массиве ___");
int col = int.Parse(Console.ReadLine()!);



int[,] FillArray(int rowArray, int colArray)
{
    int[,] arr = new int[rowArray, colArray];
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < colArray; j++)
        {
            arr[i, j] = i + j;
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

int[,] massiv = FillArray(row, col);
PrintArray(massiv);
