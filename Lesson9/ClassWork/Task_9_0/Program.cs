//Задача 1: Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от 1 до N при помощи рекурсии.


int UserInput(string Data)
{
    Console.Write(Data);
    return Convert.ToInt32(Console.ReadLine()!);
}

int number = UserInput("Input the number_");

void AllNumberFronOneToUserInput(int UserNum)
{
    if (UserNum == 0) return;
      AllNumberFronOneToUserInput(UserNum - 1);
     Console.Write($"{UserNum }\t ");
  
}

AllNumberFronOneToUserInput(number);
