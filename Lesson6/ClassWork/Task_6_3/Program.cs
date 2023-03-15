// Задача 3: Не используя рекурсию, выведите первые N чисел
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Write("Пишем число и получаем фибоначи_");
int num = int.Parse(Console.ReadLine()!);
int Fibonachi(int n)
{
    int fibo1 = 0;
    int fibo2 = 1;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{fibo1} ");
        (fibo1, fibo2) = (fibo2, fibo2 + fibo1);

    }
    return fibo1;
}

Fibonachi(num);

