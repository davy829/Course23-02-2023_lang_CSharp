// Напишите программу, которая задаёт массив из
//8 элементов случайными числами и выводит их на экран.
//Оформите заполнение массива и вывод в виде функции
//(пригодится в следующих задачах)
int[] FullArray(int Size, int Start1, int End1)
{
    int[] Arr = new int[Size]; // создаем массив 
    for (int i = 0; i < Arr.Length; i++)  // цикл равен длине
        Arr[i] = new Random().Next(Start1, End1); //наполняем случайными
    return Arr;
}

void PrintArray(int[] Array)
{
    int len = Array.Length;
    for (int i = 0; i < len; i++)
        Console.Write($"{Array[i]} "); //выводим на экран
    Console.WriteLine();
}


Console.Write("Введите размер массива___");
int len = int.Parse(Console.ReadLine()!); // принимаем размер массива
Console.Write("Введите стартовое __");
int Start2 = int.Parse(Console.ReadLine()!); // принимаем меньший значение
Console.Write("Введите финишное __");
int End2 = int.Parse(Console.ReadLine()!); // принимаем болшее значение

int[] massiv = FullArray(len, Start2, End2);
PrintArray(massiv);