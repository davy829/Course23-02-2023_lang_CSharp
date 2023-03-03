// See https://aka.ms/new-console-template for more information
Console.Write("Введите два разных числа _");
int MyNum = int.Parse(Console.ReadLine()!);
int MyNum2 = int.Parse(Console.ReadLine()!);
if (MyNum > MyNum2)
{
    Console.WriteLine($" Больше :{MyNum}");
}
else
{
    Console.WriteLine($" Больше :{MyNum2}");  
}