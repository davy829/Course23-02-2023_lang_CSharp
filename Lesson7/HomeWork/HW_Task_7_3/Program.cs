// Задача 3: Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом
//столбце.
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
            int value = new Random().Next(10, 99);
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


void SearchInArray(int[,] tmpArray)
{
    int rowArray = tmpArray.GetLength(0);
    int colArray = tmpArray.GetLength(1);
    double summ = 0;
    for (int i = 0; i < colArray; i++)
    {
        summ = 0;
        for (int j = 0; j < rowArray; j++)
        {
            summ = summ + tmpArray[j, i];       // 
        }
        Console.WriteLine();
        Console.Write($" среднее арифметич {summ / rowArray}  столб № {i + 1}");
    }
}

int[,] MyArray = FullArray(row, col);
PrintArray(MyArray);
Console.WriteLine();
SearchInArray(MyArray);
