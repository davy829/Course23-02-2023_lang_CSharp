// 0 Напишите программу на входе координаты х у
// на выходе в какой четверти лежит точка 
Console.Write("Введите кординаты точки x and y_");

int MyX = int.Parse(Console.ReadLine()!);
int MyY = int.Parse(Console.ReadLine()!);

void Quater(int x, int y)
{
    if (x == 0 || y == 0)     // если координаты равны нулю -- ругаемся
    Console.WriteLine("Try again !!!");
    else if (x > 0 && y > 0)    // икс болше нуля игрик больше нуля выводим четверть 1
    Console.WriteLine($"x -> {x},y -> {y}  =   I ");
    else if (x < 0 && y > 0)   // икс меньше нуля игрик больше нуля выводим четверть 2
    Console.WriteLine($"x -> {x},y -> {y}  =   II ");
    else if (x < 0 && y < 0)   // икс меньше нуля игрик меньше нуля выводим четверть 3
    Console.WriteLine($"x -> {x},y -> {y}  =   III ");
    else if (x > 0 && y < 0)  // икс болше нуля игрик меньше нуля выводим четверть 4
    Console.WriteLine($"x -> {x},y -> {y}  =   IV ");
    }

    Quater(MyX,MyY);