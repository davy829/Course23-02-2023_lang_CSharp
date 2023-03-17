/* Задача 2: Задайте двумерный массив. Найдите элементы, у которых
обе позиции чётные, и замените эти элементы на их квадраты. */


Console.Write("Сколько строк в массиве ___");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Сколько column в массиве ___");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Min в массиве ___");
int min = int.Parse(Console.ReadLine()!);
Console.Write("max в массиве ___");
int max = int.Parse(Console.ReadLine()!);


int[,] FillArray(int rowArray,int colArray,int start, int end)
{
  int[,] arr = new int[rowArray,colArray];
  for (int i = 0; i < rowArray; i++)
  {
    for (int j = 0; j < colArray; j++)
    {
       arr[i,j]= new Random().Next(start,end); 
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
       Console.Write($" {array[i,j]} ") ;
    }
    Console.WriteLine();  
  }

}


void FindPositivPosition(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
   for (int i = 1; i < row; i=i+2)
   {
    for (int j = 1; j < col; j=j+2)
    {
        array[i,j] = array[i,j] * array[i,j];
    }
   }
}


int[,] massiv= FillArray(row,col,min,max);
PrintArray(massiv);
 Console.WriteLine("---");
 FindPositivPosition(massiv);
PrintArray(massiv);
