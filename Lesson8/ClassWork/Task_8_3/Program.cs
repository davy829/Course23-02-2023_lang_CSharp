// See https://aka.ms/new-console-template for more information
int[] MyArray = { 1, 5, 3, 6, 4, 2, 5, 1, 1, 9, 8 };



void PrintArr(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SortArray(int[] array)
{
    for (int i = 0; i < array.Length -1 ; i++)
    {
       int MinPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinPos]) MinPos = j;
            int temp = array[i];  // сохраняем значение массива в темп
            array[i] = array[MinPos]; // меняем это знасение в массиве на минимал
            array[MinPos] = temp; // и в минимальную записываем сохраненное  МЕНЯЕМ МЕСТАМИ !!! 
        }
    }

}
PrintArr(MyArray);
SortArray(MyArray);
PrintArr(MyArray);
