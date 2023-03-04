// расстояние между двумя точками в 3д 56
Console.WriteLine("Введите значения 6 шт/ через запятую _");

void Dis3d(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    Console.WriteLine($"Расстояние между двумя точками = {Math.Round(res, 2)} ");
}
Dis3d(1.2, 7.5, 9.8, 3.6, 5, 8.4);

