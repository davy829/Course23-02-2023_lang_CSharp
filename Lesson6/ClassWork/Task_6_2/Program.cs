// See https://aka.ms/new-console-template for more information
Console.Write("Введите длинну массива___");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение массива___");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное массива___");
int max = int.Parse(Console.ReadLine()!);


int[] FullArray(int len, int from, int to)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void PrintArr(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void ReturnArr(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len / 2; i++)
    {
        (array[i], array[len - i-1]) = (array[len - i-1], array[i]);
    }
   
}


int[] massiv = FullArray(Size, min, max);
PrintArr(massiv);
Console.WriteLine();
ReturnArr(massiv);
PrintArr(massiv);