// Задача 1: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Склько чисел будете вводить?___");
string cntString = Console.ReadLine()!;
//int cnt = int.Parse(Console.ReadLine()!);

void CountZero(int cnt)
{
    int num = 0;
    int count = 0;
    for (int i = 0; i < cnt; i++)
    {
        Console.Write("Input number___");
        num = int.Parse(Console.ReadLine()!);
        if (num > 0) count++;
    }
    Console.WriteLine($"User Input : {count} number > 0");
}

void DontInputCount(string UserIn)
{
    int num = int.Parse(UserIn);
    int count = 0;
          for (int i = 0; i < 15; i++)
          {
        if (string.IsNullOrEmpty(UserIn)) 
        {
           Console.WriteLine("Выходим из цикла");
            return;
        }
       else
    {
        if (num > 0) count++;
        Console.Write("Input number___");
        num = int.Parse(Console.ReadLine()!);
    }
          }
Console.WriteLine($"User Input : {count} number > 0"); 
}


if (string.IsNullOrEmpty(cntString))
{
    Console.Write("Ладно вводи свои цифры__");
    DontInputCount(Console.ReadLine()!);
}
else
{
    CountZero(int.Parse(cntString));
}