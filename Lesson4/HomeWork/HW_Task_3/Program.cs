// Напишите программу, которая задаёт массив из
//8 элементов случайными числами и выводит их на экран.
//Оформите заполнение массива и вывод в виде функции
//(пригодится в следующих задачах)

Console.Write("Введите размер массива___"); 
int len = int.Parse(Console.ReadLine()!); // принимаем размер массива
int[] massiv = new int[len]; // создаем массив 


void FullArray(int[] MyArray)
{
    int len = MyArray.Length; // узнаем длину 
    for (int i = 0; i < len; i++)  // цикл равен длине
    {
        MyArray[i] = new Random().Next(1,99); //наполняем случайными
        Console.Write($",{MyArray[i]}"); //выводим на экран
    }
   
}

FullArray(massiv);