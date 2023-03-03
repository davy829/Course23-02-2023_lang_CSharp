// показывает какое из введенных чисел больше
Console.Write("Введите два разных числа _");
int MyNum = int.Parse(Console.ReadLine()!);
int MyNum2 = int.Parse(Console.ReadLine()!);
if (MyNum > MyNum2)
{
    Console.WriteLine($" {MyNum} > {MyNum}");
}
else
{
    Console.WriteLine($" {MyNum} < {MyNum2}");  
}