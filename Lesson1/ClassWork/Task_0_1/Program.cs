// является ли оно квадратом первого
Console.Write("Введите первое число _"); //предложение для пользователя
int FirstNum = int.Parse(Console.ReadLine()!); //читаем что ввел
Console.Write("Введите второе число мы проверим является ли оно квадратом первого _"); //просим второе число
int SecondNum = int.Parse(Console.ReadLine()!); //читаем
int squear = FirstNum * FirstNum;  // считаем квадратный корень
if (squear == SecondNum) // сравним результат  со вторым числом
{
Console.Write($"Yes!!  {SecondNum} is squear of {FirstNum}");  //если  корень то говорим есы
}
else
{
 Console.Write($"No!  {SecondNum} is not squear of {FirstNum}");     
}

