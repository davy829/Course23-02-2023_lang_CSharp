// 0. Напишите программу, которая принимает на вход трёхзначное число
	//    и на выходе показывает последнюю цифру этого числа.
//Console.Write("Введите трехзначное число _");
int LastNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int resault = LastNum(new Random().Next(100,999));

Console.WriteLine(resault);
