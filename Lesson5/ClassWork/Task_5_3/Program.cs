// Задача 3: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99]. 

Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите меншее значение в массиве_");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее значение в массиве_");
int to = int.Parse(Console.ReadLine()!);

int[] FullArray(int ArrayLen, int ArrayMin,int ArrayMax)
{
    int[] arr = new int[ArrayLen];
    for (int i = 0; i < ArrayLen; i++)
    {
        arr[i] = new Random().Next(ArrayMin,ArrayMax);
    }
    return arr;
}

void PrinrMyArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void FindNum(int[] FArray,int FindMax,int FindMin)
{
    int count =0;
  for (int i = 0; i < FArray.Length; i++)
  {
    if (FArray[i] > 10 && FArray[i] < 99)
    count ++;
  }
  Console.Write($"в этом массиве элементов > 10 < 99 всего: {count}");
}



int[] massiv = FullArray(Size,from,to);
PrinrMyArr(massiv);
Console.WriteLine();
Console.Write("Что ищем? Введите мин_");
int ArrMin1 = int.Parse(Console.ReadLine()!);
Console.Write("Что ищем? Введите мax_");
int ArrMax1 = int.Parse(Console.ReadLine()!);
FindNum(massiv,ArrMin1,ArrMax1);
