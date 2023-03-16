// Задача 2. Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями y = k1 *
//x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
//пользователем.

Console.WriteLine("Введите 4 параметра");
double b1 = double.Parse(Console.ReadLine()!);  //  2;
double k1 = double.Parse(Console.ReadLine()!);  // 5;
double b2 = double.Parse(Console.ReadLine()!);  // 4;
double k2 = double.Parse(Console.ReadLine()!);  // 9;

void SaerchLine(double v1,double h1, double v2,double h2)
{
double x= (v2 - v1)/(h1 - h2);
double y = h1 * x + v1;
Console.WriteLine($"x = {x}, y = {y}");
}

SaerchLine(b1,k1,b2,k2);