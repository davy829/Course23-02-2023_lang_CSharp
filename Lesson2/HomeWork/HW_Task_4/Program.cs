// прооверяет выходной или рабочий день 
Console.Write("Введите цифру желательно от 1 до 7 _ ");
int Num = int.Parse(Console.ReadLine()!);
if (Num < 8)
{
    if (Num == 6 | Num == 7) Console.WriteLine("Выходной !");
    if (Num > 0 & Num < 6) Console.WriteLine("Будний день> !");
}
else
{
    Console.WriteLine("Ваше число вышло из диапозона  дней недели");
}