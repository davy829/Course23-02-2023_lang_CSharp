// Задача 4: Напишите программу, которая будет создавать
//копию заданного массива с помощью поэлементного
//копирования.
Console.Write("ВВедите размер массива__");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("ВВедите min value массива__");
int minVal = int.Parse(Console.ReadLine()!);
Console.Write("ВВедите max value массива__");
int maxVal = int.Parse(Console.ReadLine()!);


int[] FillArray(int len, int min,int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i]= new Random().Next(min,max) ;
    }
    return arr;
}

void PrintArr(int[]array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] CopyArray(int[] array)
{
    int len=array.Length;
 int[] arr= new int[len];
 for (int i = 0; i < len; i++)
 {
    arr[i]=array[i];
 }
 return arr;
}



int[] massiv = FillArray(Size,minVal,maxVal);
PrintArr(massiv);
Console.WriteLine("__copy>");
int[] massiv2 = CopyArray(massiv);
PrintArr(massiv2);