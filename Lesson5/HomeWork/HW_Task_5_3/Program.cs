//Задача 3: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.

Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите меншее значение в массиве_");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее значение в массиве_");
int to = int.Parse(Console.ReadLine()!);

double[] FullArray(int len, int start, int end)
{
    double[] arr = new double[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() *  start * end,2);
    }
    return arr;
}

void PrintArray(double[] Array)
{
    int len = Array.Length;
    for (int i = 0; i < len; i++)
    {
     Console.Write($"{Array[i]}- ");
    }
}

double MinMax(double[] Array)
{
    int len=Array.Length;
    double min=Array[0];
    double max=Array[0];
    double resault=0;
    for (int i = 1 ; i < len; i++)
    {
      if (Array[i] < min)  
      min = Array[i];
      if (Array[i] > max)
      max = Array[i];
    }
    resault = max - min;
    Console.Write($"{max}-{min}={Math.Round(resault,3)} ");
  
    return resault;
}

double[] massiv = FullArray(Size,from,to);
PrintArray(massiv);
Console.WriteLine();
double res = MinMax(massiv);
Console.Write($"{Math.Round(res,3)}");


