//Задача 54: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateArray(int rowCount,int colCount)
{
    int[,] myArray = new int[rowCount,colCount];
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
           Array[i,j] = new Random().Next(10,55); 
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
         resault += Array[i,j];
       if (j != col-1)
         resault += "\t";
         else
         resault += "\n";
       } 
    }
    return resault;
}


void SortDownRows(int[,] Array)
{
   int min = Array[0,0];
    int row = Array.GetLength(0);
    int col = Array.GetLength(1);
    for (int i = 1; i < col; i++)
    {
       for (int j = 1; j < row; j++)
       {
        if (min < Array[j,i])
           (min , Array[j,i]) = (Array[j,i], min);

       } 
    }

}



int[,] massiv = CreateArray(3,3);
FullArray(massiv);
string massivToString = PrintArray(massiv);
Console.WriteLine(massivToString);
SortDownRows(massiv);
string myArraySort = PrintArray(massiv);
Console.WriteLine(myArraySort);

//  TODO