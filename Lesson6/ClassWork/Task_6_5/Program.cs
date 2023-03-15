// Задача 4: Напишите программу, которая будет создавать
//копию заданного массива с помощью поэлементного
//копирования.
/* Console.Write("ВВедите размер массива__");
int Size = int.Parse(Console.ReadLine()!); */
Console.Write("ВВедите count rows массива__");
int row = int.Parse(Console.ReadLine()!);
Console.Write("ВВедите count columns массива__");
int col = int.Parse(Console.ReadLine()!); 

int[,] FillArray(int[,] myArray)
{
    int myArrayRow = myArray.GetLength(0);
    int myArrayCol = myArray.GetLength(1);
    for (int i = 0; i < myArrayRow; i++)
    {
        for (int j = 0; j < myArrayCol; j++)
        {
            myArray[i, j] = new Random().Next(0, 2);
        }

    }
    return myArray;
}


void PrintArray(int[,] arr)
{
    int myArrayRow = arr.GetLength(0);
    int myArrayCol = arr.GetLength(1);
    for (int i = 0; i < myArrayRow; i++)
    {
        for (int j = 0; j < myArrayCol; j++)
        {
           
          Console.Write($"{arr[i, j]} ");  
        }
      Console.WriteLine(); 
    }
}

int[,] CopyArray(int[,] CopyArray)
{

    int myArrayRow = CopyArray.GetLength(0);
    int myArrayCol = CopyArray.GetLength(1);
    int[,] arr2 = new int[myArrayRow,myArrayCol];
    for (int i = 0; i < myArrayRow; i++)
    {
        for (int j = 0; j < myArrayCol; j++)
        {
           
         arr2[i,j]= CopyArray[i,j] ;
        }
     
    }
    return arr2;
}


int[,] matrix = new int[row, col];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("______"); 
int[,] matrix2 = CopyArray(matrix);
PrintArray(matrix2);


