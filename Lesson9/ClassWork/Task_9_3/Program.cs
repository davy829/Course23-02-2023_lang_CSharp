// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии.

int UserInput(string userData)
{
    Console.Write(userData);
    return Convert.ToInt32(Console.ReadLine()!);
}

int numA = UserInput("Input your A number_");
int numB = UserInput("Input your B number_");


int Degree(int a, int b)
{
    if (b == 0) return 1;
   return a * Degree(a ,b-1);
}

int res = Degree(numA,numB);
Console.Write($"{res }");