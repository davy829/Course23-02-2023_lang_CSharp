// See https://aka.ms/new-console-template for more information
Console.Write("Введите длинну сторон треугольника_");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);


void Triangle(int a1, int b1, int c1)
{
    if (a1 > b1 + c || b1 > c1 + a1 || c1 > a1 + b1)
    {
        Console.Write("Нет такого треугольника_");
    }
    else
    {
        Console.Write("такой существует треугольник");
    }
}

Triangle(a, b, c);