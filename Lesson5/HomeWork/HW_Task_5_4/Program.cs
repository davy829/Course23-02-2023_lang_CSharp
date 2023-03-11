//сортировка
//
//элементов массива.

Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите меншее значение в массиве_");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее значение в массиве_");
int to = int.Parse(Console.ReadLine()!);

int[] FullArray(int len, int start, int end)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(start,end);
    }
    return arr;
}

void PrintArray(int[] Array)
{
    int len = Array.Length;
    for (int i = 0; i < len; i++)
    {
     Console.Write($"{Array[i]} ");
    }
}

int SortArray(int[] Array)
{
    int len=Array.Length;
    int min=Array[0];
    int max=Array[0];
    int resault=0;
    for (int i = 0; i < len; i++)
    {
        int minPos=i;
     for (int j = 0; j < len; j++)
     {
      if (Array[i] > max)
      {
      max = Array[i];

      }  
     }
      
    }
    resault = max - min;
    Console.Write($"{max}-{min}={resault} ");
  
    return resault;
}

int[] massiv = FullArray(Size,from,to);
PrintArray(massiv);
Console.WriteLine();
int res = SortArray(massiv);
Console.WriteLine($"{res}");


