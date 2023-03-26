// Задача 58: Задайте две матрицы. Напишите программу, которая будет
//находить произведение двух матриц.

void FullArray(int[,] myArray)
{
    Random rnd = new Random();
 int rows = myArray.GetLength(0);
 int col = myArray.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < col; j++)
    {
        myArray[i,j] = rnd.Next(2,9);
    }
  }
}


void PrintArray2d(int[,] myArray)
{
    int rows = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
          Console.Write($"{myArray[i,j]} \t");           
            
        }
        Console.WriteLine();
    }
    
}

int[,] Proizvedenie(int[,] matOne,int[,] matTwo)
{
    int rowMatrixOne = matOne.GetLength(0);
    int colMatrixOne = matOne.GetLength(1);
    int[,] resMatrix = new int[rowMatrixOne,colMatrixOne];
     for (int i = 0; i < rowMatrixOne; i++)
     {
        for (int j = 0; j < colMatrixOne; j++)
        {
           resMatrix[i,j] = matOne[i,j] * matTwo[i,j];
        }
     }
     return resMatrix;
}



int[,] matrixOne = new int[8,8];
int[,] matrixTwo = new int[8,8];

Console.WriteLine("matrix one");
FullArray(matrixOne);
PrintArray2d(matrixOne);

Console.WriteLine("matrix two");
FullArray(matrixTwo);
PrintArray2d(matrixTwo);
Console.WriteLine("matrix Proizvedenie");
int[,] matrixResault = Proizvedenie(matrixOne,matrixTwo);
PrintArray2d(matrixResault);

