int length = 10;   // длина массива 
int[] Myarray = new int[length]; // создаем массив

void FillArray(int[] array, int len)
{
    for (int i = 0; i < len; i++)
  {
   int OneZero = new Random().Next(0,2); // произвольное 0 или 1
   array[i] = OneZero; // наполняем
   Console.Write($"{array[i]}, "); // выводим 
  }
  
}
FillArray(Myarray,length); // зовем функцию даем ей массив и длинну