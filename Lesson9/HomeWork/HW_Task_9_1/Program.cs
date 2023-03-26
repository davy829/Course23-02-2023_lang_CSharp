// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
//чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int UserInput(string userData)
{
    Console.Write(userData);
    return Convert.ToInt32(Console.ReadLine()!);
}
int numM = UserInput("Input your M number_");
int numN = UserInput("Input your N number_");

void EvenNumbers(int M, int N)
{
    if (M < N)
    {

        if (M == N) return;
        EvenNumbers(M, N - 1);
        if (N % 2 == 0) Console.Write($"{N}\t ");
    }
    else
    {
        if (M == N) return;
        EvenNumbers(M - 1, N);
        if (M % 2 == 0) Console.Write($"{M}\t ");
    }
}

EvenNumbers(numM, numN);
