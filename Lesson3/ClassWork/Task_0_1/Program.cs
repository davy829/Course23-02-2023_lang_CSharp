// по номеру четверти графика определяет координаты возможные
Console.Write("Введите номер четверти __");
int MyQuater = int.Parse(Console.ReadLine()!);

void Coord(int MQ)
{
  if (MQ > 0 && MQ < 5)
  {
    if (MQ == 1)
    Console.Write("Первая Четверть Координаты x > 0, y > 0 ");
    if (MQ == 2)
    Console.Write("Вторая Четверть Координаты x < 0, y > 0 ");
    if (MQ == 3)
    Console.Write("Тоетья Четверть Координаты x < 0, y < 0 ");
    if (MQ == 4)
    Console.Write("Четвертая Четверть Координаты x > 0, y  < 0 ");
  }
  else
    Console.Write("Ваше число вышло из диапазона !!!");
}
Coord(MyQuater);

