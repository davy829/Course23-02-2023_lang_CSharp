	// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
	//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
	//    программа выводит остаток от деление.
Console.WriteLine("Input Two numbers_");

void KranOrNo(int firstNum, int SecNum)
{
    int ostatok = firstNum % SecNum;
    if ( ostatok == 0)
    {
    Console.WriteLine($"no Кратное! остаток :{ostatok}");
    }
    else
    {
     Console.WriteLine($"Кратное! остаток :{ostatok}");
    }
   
}
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
KranOrNo(num1, num2);
