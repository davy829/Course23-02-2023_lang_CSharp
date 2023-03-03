	// 1. Напишите программу, которая выводит случайное число
	//    из отрезка [10, 99] и показывает наибольшую цифру числа.
int MaxNum(int num)
{
    Console.WriteLine($" this is number: {num}");
    int num1 = num / 10; //делим на 10
    int num2 = num % 10; // остаток от деления на 10
    if (num1 > num2) 
    {
       return num1;
    }
       else
    {
       return num2; 
    }

}

int resault = MaxNum(new Random().Next(10,99));

Console.WriteLine($"Max value off {resault}");