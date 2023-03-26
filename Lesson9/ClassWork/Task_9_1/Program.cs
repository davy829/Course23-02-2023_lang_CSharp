// Задача 2: Задайте значения M и N. Напишите программу, которая
//рекурсивно выведет все натуральные числа в промежутке от M до N.

int UserInput(string userData)
{
    Console.Write(userData);
    return Convert.ToInt32(Console.ReadLine()!);
}

void DiapazonNaturalNumbers(int userNumberOne, int userNumberTwo)
{
    if (userNumberOne < userNumberTwo)
    {
       
 if (userNumberOne == userNumberTwo) return;
       DiapazonNaturalNumbers(userNumberOne, userNumberTwo - 1);
        Console.Write($"{userNumberTwo}\t ");
      }
      else
{
     if (userNumberOne == userNumberTwo) return;
       DiapazonNaturalNumbers(userNumberOne-1, userNumberTwo);
        Console.Write($"{userNumberOne}\t ");
}
}



int usrDta = UserInput("Input  number one_");
int usrDta2 = UserInput("Input  number two_");

DiapazonNaturalNumbers(usrDta,usrDta2);
