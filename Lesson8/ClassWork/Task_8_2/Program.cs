/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

int UserInput(string myData)
{
    Console.Write(myData);
    return Convert.ToInt32(Console.ReadLine()!);
}

int[,] CreateArray(int rowCount, int colCount)
{
    return new int[rowCount, colCount];
}

void FullArray(int[,] myArray, int min, int max)
{
    Random rnd = new Random();
    int row = myArray.GetLength(0);
    int col = myArray.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            myArray[i, j] = rnd.Next(min, max);
        }
    }
}

string PrintArray(int[,] Array)
{
    string res = string.Empty;
    int row = Array.GetLength(0);
    int col = Array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            res += Array[i, j];
            if (j != col - 1)
                res += "\t";
            else
                res += "\n";
        }
    }
    return res;
}

int[] Frequency(int[,] Array, int maxVal)
{
    int[] arr = new int[maxVal + 1];
    foreach (int element in Array)
    {
        arr[element]  += 1;
    }
    return arr;
}

string PrintFrequency(int[] array)
{
    string res = string.Empty;
    for (int i = 0; i < array.Length; i++)
        res += $"число {i} встречается {array[i]}  раз \n";
    return res;
}

int myRow = UserInput("Input rows count_");
int myCol = UserInput("Input col count_");
int[,] Array2D = CreateArray(myRow, myCol);
int minVal = UserInput("Input min value_");
int maxVal = UserInput("Input max value_");
FullArray(Array2D, minVal, maxVal);
string myArr = PrintArray(Array2D);
Console.WriteLine(myArr);
int[] arrayDic = Frequency(Array2D, maxVal);
string resault = PrintFrequency(arrayDic);
Console.WriteLine(resault);
