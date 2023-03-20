/* // Задача 2: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
 */
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
            Console.Write($"{tmpArray[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

int FindPosReturnVal(int[,] Array, int FRow,int FCol)
{
  int row = Array.GetLength(0);
  int col =Array.GetLength(1);
  int value = 0;
  if (row >= FRow & col >= FCol)
  {
   value = Array[FRow-1,FCol-1];
     Console.Write($"позиции[{FRow},{FCol}] содержат значение: {value}");
  }
   else  Console.Write("Такого элемента нет в массиве");
 return value;
}


int[,] MyArray = FullArray(row, col);
PrintArray(MyArray);
Console.Write("Input value one _");
int one = int.Parse(Console.ReadLine()!);
Console.Write("Input value two _");
int two = int.Parse(Console.ReadLine()!);
FindPosReturnVal(MyArray,one,two);
