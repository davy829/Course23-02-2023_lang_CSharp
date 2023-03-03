// See https://aka.ms/new-console-template for more information
Console.Write("Введите три разных числа _");
int MyNum = int.Parse(Console.ReadLine()!);
int MyNum2 = int.Parse(Console.ReadLine()!);
int MyNum3 = int.Parse(Console.ReadLine()!);
int max = MyNum;
if (MyNum2 > max);
{
    max = MyNum2;
}
if (MyNum3 > max);
{
    max = MyNum3;
}
Console.Write($"Большее :{max}");
