// Задача 59: Задайтедвумерный массив из целых чисел. Напишите программу,
//которая удалит строку и столбец, на пересечении которых расположен
//наименьший элемент массива.


void FullArray(int[,] myArray)
{
    int row = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            myArray[i, j] = new Random().Next(10, 50);
        }
    }
}

string PrintArray(int[,] myArray)
{
    string ArrToStr = string.Empty;
    int row = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            ArrToStr += myArray[i, j];
            if (j != col - 1)
                ArrToStr += "\t";
            else
                ArrToStr += "\n";

        }
    }
    return ArrToStr;
}

int[] MinElementValue(int[,] myArray)
{

    int min = myArray[0, 0];
    int minI = 0;
    int minJ = 0;
    int row = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (myArray[i, j] < min)
            {
                min = myArray[i, j];
                minI = i;
                minJ = j;
            }

        }


    }
    Console.WriteLine($" строка {minI+1} - > столбец {minJ+1} значение {min}");
    return new int[] { min, minJ };
}

int[,] CreateArrayWithoutMinRow(int[,] myArray, int[] ArrayIndex)
{
    int rowDel = ArrayIndex[0];
    int colDel = ArrayIndex[1];
    int row = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    int[,] resArray = new int[row - 1, col - 1];

    for (int i = 0, k = 0; i < row-1; k++, i++)
    {
        if (i != rowDel)
            for (int j = 0, l = 0; j < col; l++, j++)
            {
                if (j != colDel)
                    resArray[k, l] = myArray[i, j];
                else l--;
            }
        else
            k--;
    }
    return resArray;
}

int[,] Array = new int[3, 4];
FullArray(Array);
string res = PrintArray(Array);
Console.Write(res);


MinElementValue(Array);
int[] DelRowCol = MinElementValue(Array);
int[,] resaultDelete = CreateArrayWithoutMinRow(Array, DelRowCol);
string resDel = PrintArray(resaultDelete);
Console.Write(resDel);