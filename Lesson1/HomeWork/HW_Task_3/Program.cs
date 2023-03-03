// проверяет четное или нет
Console.Write("Введите любое число, проверим четное или нет_");
int MyNum = int.Parse(Console.ReadLine()!);
int Resault = (MyNum % 2);
if (Resault == 0)
{
Console.WriteLine($"{Resault} : число четное");
}
else
{
 Console.WriteLine($"{Resault} : число ne четное");   
}