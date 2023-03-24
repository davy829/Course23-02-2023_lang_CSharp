// Задача 59: Задайтедвумерный массив из целых чисел. Напишите программу,
//которая удалит строку и столбец, на пересечении которых расположен
//наименьший элемент массива.


void FullArray(int[,] myArray)
{
    int row=myArray.GetLength(0);
    int col=myArray.GetLength(1);
   for (int i = 0; i < row; i++)
   {
    for (int j = 0; j < col; j++)
    {
        myArray[i,j]= new Random().Next(10,50);
    }
   }
}

string PrintArray(int[,]myArray)
{
    string ArrToStr = string.Empty;
       int row=myArray.GetLength(0);
    int col=myArray.GetLength(1);
   for (int i = 0; i < row; i++)
   {
    for (int j = 0; j < col; j++)
    {
        ArrToStr+=myArray[i,j];
      if (j != col-1)
       ArrToStr += "\t";
       else
       ArrToStr+= "\n";

    }
   }
   return ArrToStr;
}

void MinElementValue(int[,] myArray)
{
    int min=myArray[0,0];
    int minI=0;
    int minJ=0;
    int row = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    for (int i = 1; i < row; i++)
    {
        for (int j = 1; j < col; j++)
        {
          if (myArray[i,j] < min)
          {
            min = myArray[i,j];
            minI=i;
            minJ=j;
          }
           
        }

          
    }
Console.WriteLine($" i {minI} - > j {minJ}");
}



int[,] Array = new int[4,4];
FullArray(Array);
string res = PrintArray(Array);
Console.Write(res);
MinElementValue(Array);

