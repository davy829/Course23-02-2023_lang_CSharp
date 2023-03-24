// Задача 56: Задайте прямоугольный двумерный массив. Напишите
//программу, которая будет находить строку с наименьшей суммой элементов.

void FullArray(int[,] Array)
{
    int row = Array.GetLength(0);
    int col = Array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Array[i, j] = new Random().Next(10, 55);
        }
    }
}

void PrintArray2d(int[,] array)
{
    // string res = string.Empty;
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            /*        res += array[i,j];
                   if (j != col-1)
                   res += "\t";
                   else
                   res += "\n"; */
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
    //return res;
}

int[] SummRowsElement(int[,] myArray)
{

    int row = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    int[] mass = new int[row];
    for (int i = 0; i < row; i++)
    {
        int summ = 0;
        for (int j = 0; j < col; j++)
        {
            summ += myArray[i, j];

        }
        mass[i] = summ;
        //  Console.WriteLine($"{i} - > {summ}");
    }
    return mass;
}

int FindMinSummRow(int[] myArr)
{
    int min = myArr[0];
    int minIndex = 0;
    for (int i = 1; i < myArr.Length; i++)
    {
        if (myArr[i] < min)
        {
            min = myArr[i];
            minIndex = i + 1;
        }
    }
    return minIndex;
}

string PrintRowMinSumm(int[,] myArray2d, int myRow)
{
    string rowMinSumValue = string.Empty;
    for (int i = 0; i < myArray2d.GetLength(1); i++)
    {
        rowMinSumValue += $" {myArray2d[myRow, i]}";
    }
    return rowMinSumValue;
}

int[,] massiv = new int[8, 3];
FullArray(massiv);
PrintArray2d(massiv);
int[] myArray = SummRowsElement(massiv);
int res = FindMinSummRow(myArray);
Console.WriteLine($"+-------------------------------------------------+");
Console.WriteLine($"номер строки {res} с минимальной суммой elements");
string MinRowSumm = PrintRowMinSumm(massiv, res);
Console.WriteLine($"строкa {MinRowSumm} с минимальной суммой elements");
Console.WriteLine($"+_________________________________________________+");