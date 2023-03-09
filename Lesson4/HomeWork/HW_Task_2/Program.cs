//  Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
Console.Write("впиши число ___");
int num = int.Parse(Console.ReadLine()!);
// двухзначное
if (num < 100)
{
    int one = num / 10;
    int two = num % 10;
    int res = one + two;
    Console.WriteLine($"{one} + {two} = {res}");
}
// трехзначное
if (num > 100 && num < 1000)
{
    int one = num / 100;
    int two = num / 10 % 10;
    int three = num % 10;
    int res = one + two + three;
    Console.WriteLine($"{one} + {two} + {three} = {res}");
}

//четырехзначное
if (num > 1000 && num < 10000)
{
    int one = num / 1000;
    int two = num / 100 % 10;
    int three = num / 10 % 10;
    int four = num % 10;
    int res = one + two + three + four;
    Console.WriteLine($"{one} + {two} + {three} + {four} = {res}");
}