// из трехзначного ввод пользователя числа вернет вторую цифру

int SecondNum(int MyNum)
{
    int firstNum = MyNum / 10; // делим трехзнак на 10 -- (235 / 10 = 23)
    int SecNum = firstNum % 10; // остаток от деления на 10 -- вторая цифра
    return SecNum;
}
Console.Write("Введите трехзначное число! _");
int num = int.Parse(Console.ReadLine())!; // читаем что ввел юзер
if (num > 99 & num < 999)               //проверяем что трехзначное
{
int resault = SecondNum(num);  // ловим результат функции в резаулт
Console.WriteLine($"Вторая цифра : {resault}");  //выводим результат
}

