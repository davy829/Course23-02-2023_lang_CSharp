// вычисляет расстояние между заданными точками 

double Distans(double x1, double y1, double x2, double y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2))); //квадратный корень
}

Console.WriteLine(Distans(1,1,2,2));