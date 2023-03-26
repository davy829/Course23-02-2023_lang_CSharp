// Задача 3: Напишите программу, которая будет принимать на вход число и
//возвращать сумму его цифр. Использовать рекурсию.

int UserInput(string userData)
{
    Console.Write(userData);
    return Convert.ToInt32(Console.ReadLine()!);
}

int resaultSumm = UserInput("Input your number_");

int Summ(int userNum)
{
    if (userNum == 0) return 0;
    return Summ(userNum / 10) + userNum % 10; 
}

int res = Summ(resaultSumm);
Console.WriteLine($"summ- {res}");