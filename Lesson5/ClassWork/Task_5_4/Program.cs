//Задача 4: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите меншее значение в массиве_");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее значение в массиве_");
int to = int.Parse(Console.ReadLine()!);

int[] FullArray(int ArrayLen, int ArrayMin, int ArrayMax)
{
    int[] arr = new int[ArrayLen];
    for (int i = 0; i < ArrayLen; i++)
    {
        arr[i] = new Random().Next(ArrayMin, ArrayMax);
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

void FindProizvedwnieParPrint(int[] FArray)
{
    int len = FArray.Length -1;
    int[] ArrProizv = new int[len];
    int Proizvedenie = 0;
    int FirstPar = 0;
    int LastPar = 0;
    for (int i = 0; i < len / 2 +1; i++)
    {
        FirstPar = FArray[i];
        LastPar = FArray[len - i];
        Proizvedenie = FirstPar  * LastPar;
        //Console.WriteLine($"i={i} fp={FirstPar} * lp={LastPar} len-i={len - i} ");
        ArrProizv[i] = Proizvedenie;
        Console.Write($" {ArrProizv[i]}");
    }
    //
}



int[] massiv = FullArray(Size, from, to);
PrinrMyArr(massiv);
Console.WriteLine();
FindProizvedwnieParPrint(massiv);


