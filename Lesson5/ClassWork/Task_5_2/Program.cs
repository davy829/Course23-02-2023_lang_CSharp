// Задача 2: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите меншее значение в массиве_");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее значение в массиве_");
int to = int.Parse(Console.ReadLine()!);

int[] FullArray(int Size1, int from1, int to1)
{
    int[] arr = new int[Size1];
    for (int i = 0; i < Size1; i++)
    {
        arr[i] = new Random().Next(from1, to1);
    }
    return arr;
}

void PrintArray(int[] array6)
{
    int len = array6.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array6[i]} ");
    }
}

void FindNum(int[] arr, int FindNum)
{
    int len = arr.Length;
    int flag = 0;
    for (int i = 0; i < len; i++)
    {
        if (arr[i] == FindNum)
        {
         Console.WriteLine($"индекс : {i} содержит значение  {FindNum} ");
          flag = 0;
        }
        else
        {
            flag = 1;
        }
    } 
    if (flag == 1)
    {
     Console.WriteLine($"не содержит значение  {FindNum} ");
    }
}

int[] massiv = FullArray(Size, from, to);
PrintArray(massiv);
Console.WriteLine("input num_");
int FindN = int.Parse(Console.ReadLine()!);
FindNum(massiv, FindN);
