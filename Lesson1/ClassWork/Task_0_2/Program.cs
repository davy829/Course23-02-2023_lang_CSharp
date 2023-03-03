Console.Write("напишите цифру от 1 до 7 _"); //предлогаем пользователю ввести цифру
int Mday = int.Parse(Console.ReadLine()!); //читаем ее
if (Mday == 1)    // сравнивавем
{
    Console.Write("Monday"); // если 1 то понедельник
}
else if (Mday == 2)
{
    Console.Write("Teausday"); //если 2 то вторник и т.д.
}
else if (Mday == 3)
{
    Console.Write("Wednesday");
}
else if (Mday == 4)
{
    Console.Write("Thirsday");
}
else if (Mday == 5)
{
    Console.Write("Friday");
}
else if (Mday == 6)
{
    Console.Write("Saturday");
}
else if (Mday == 7)
{
    Console.Write("Sunday");
}