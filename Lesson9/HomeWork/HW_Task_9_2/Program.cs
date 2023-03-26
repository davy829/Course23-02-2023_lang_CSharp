//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.


int UserInput(string userData)
{
    Console.Write(userData);
    return Convert.ToInt32(Console.ReadLine()!);
}


int numM = UserInput("Input your M number_");
int numN = UserInput("Input your N number_");
int summ = 0;

int SummNumbers(int M, int N)
{
    if (M == N + 1) return 0; // плюс один чтобы дойти до самой меньшей цифры
    summ += N;
    SummNumbers(M, N - 1);
    return summ;
}

int res = SummNumbers(numM, numN);
Console.Write($"Summ  beetwen {numM} and {numN} = {res}");

