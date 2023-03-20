// Задача 55: Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для
//пользователя.

int UserInput(string MyData)
 {
    Console.Write(MyData);
    return Convert.ToInt32(Console.ReadLine()!);
 }

double[,] CreateArray(int rowsCount,int colCount)
{
  return  new double[rowsCount,colCount];
}

void FillArray(double[,] myArray, int minValue,int maxValue)
{
    Random rnd = new Random();
    int row = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            myArray[i,j]=Math.Round(rnd.NextDouble() *(maxValue-minValue)+minValue,0);
        }
    }

}

void PrintArray(double[,] myArray)
{
    int rows = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
           Console.Write($"{myArray[i,j]}\t ") ;
        }
        Console.WriteLine();
    }
}

bool Check(int rowCount,int colCount)
{
    bool resault = rowCount != colCount;
    return resault;
}

string ExchangeRowToColumn(double[,] myArray)
{
    if (Check(myArray.GetLength(0),myArray.GetLength(1)))
    return " No col and must be equal !!!";
    int row = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < i; j++)
        {
           (myArray[i,j],myArray[j,i])= (myArray[j,i],myArray[i,j]);
        }
    }
  return "Yes!";
}



int rows = UserInput("Input rows count_");
int col = UserInput("Input col count_");
double[,] MyArray = CreateArray(rows,col);
int minimal = UserInput("input minimal value_");
int max = UserInput("Input max value_");
FillArray(MyArray,minimal,max);
PrintArray(MyArray);
ExchangeRowToColumn(MyArray);
Console.WriteLine();
PrintArray(MyArray);
