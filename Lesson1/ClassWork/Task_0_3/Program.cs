// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите любое число от 0 до 100");
int MyNum = int.Parse(Console.ReadLine()!); // читаем что ввел юзер
int NegativNum = - MyNum;                  // добавляем пременную с таким же числом со знаком минус
while (MyNum >= NegativNum)                  // цикл пока введенное болше или равно отрицательному своему значению
{
 Console.Write($"{MyNum - 1} ,");  // выводим 
 MyNum =  MyNum -1;     // уменьшаем для выхода из цикла и подщета вывода
}