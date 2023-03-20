/* // Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

int UserInput(string MyData)
{
    Console.Write(MyData);
    return Convert.ToInt32((Console.ReadLine()!));
}

double[,] CreateArray(int arrayRows, int arrayCol)
{
    return new double[arrayRows, arrayCol];
}

void FillArray(double[,] array, int Min, int Max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() * (Max - Min) + Min, 2);
        }
    }
}


void PrintArray(double[,] array)
{
    int myRow = array.GetLength(0);
    int myCol = array.GetLength(1);
    for (int i = 0; i < myRow; i++)
    {
        for (int j = 0; j < myCol; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ExchangFirstLastRow(double[,] array)
{
    int myCol = array.GetLength(1);
    for (int j = 0; j < myCol; j++)
    {
        (array[0, j], array[myCol, j]) = (array[myCol, j], array[0, j]);
    }

}



int Rows = UserInput("Input rows count_");
int Col = UserInput("Input columns count_");
double[,] MyArray = CreateArray(Rows, Col);
int minVal = UserInput("Input minimal value in array_");
int maxVal = UserInput("Input maximal value in array_");
FillArray(MyArray, minVal, maxVal);
PrintArray(MyArray);
ExchangFirstLastRow(MyArray);
Console.WriteLine();
PrintArray(MyArray);
