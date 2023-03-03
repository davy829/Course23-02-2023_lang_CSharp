Console.Write("Введите любое число_ ");
int MyNum = int.Parse(Console.ReadLine()!);
int MyNum2 = MyNum - 1 ; // если нечетное минус один , сразу четное

while (MyNum >= 2) // выполняем пока введенное больше или равно 2
{
if (MyNum % 2 == 0) // если остаток деления введеного 0 выполняем вывод с четного числа
{    
 Console.Write($"{MyNum}, "); 
 MyNum = MyNum - 2; 
}
else // если остаток деления введеного 1 выполняем вывод с не четного числа (минус 1) в строке 3
{    
 Console.Write($"{MyNum2}, "); 
 MyNum2 = MyNum2 - 2; 
 MyNum = MyNum - 2; 

}
}