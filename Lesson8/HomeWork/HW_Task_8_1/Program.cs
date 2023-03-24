//Задача 54: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateArray(int rowCount, int colCount)
{
    int[,] myArray = new int[rowCount, colCount];
    return myArray;
}

void FullArray(int[,] Array)
{
    int row = Array.GetLength(0);
    int col = Array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Array[i, j] = new Random().Next(10, 99);
        }
    }
}

string PrintArray(int[,] Array)
{
    string resault = string.Empty;
    int row = Array.GetLength(0);
    int col = Array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            resault += Array[i, j];
            if (j != col - 1)
                resault += "\t";
            else
                resault += "\n";
        }
    }
    return resault;
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                 (array[i,k],array[i,k+1]) = (array[i,k+1],array[i,k]);
          }

        }

    }

}




int[,] massiv = CreateArray(8, 8);
FullArray(massiv);
string massivToString = PrintArray(massiv);
Console.WriteLine(massivToString);
PrintArray(massiv);
Console.WriteLine("The sort array max > min ");
SortArray(massiv);
string sortArrayStr = PrintArray(massiv);
Console.WriteLine(sortArrayStr);


//  TODO третий цикл