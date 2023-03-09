Console.Write("Input random number _");
int Mynum = int.Parse(Console.ReadLine()!);
int Sum(int num)
{
    int res = 0;
    for (int i = 0; i < num; i++)
    {
        res = res + num - i;
        Console.Write($" + {num-i}  ");
        // исползовал как отладку для просмотра значений
    }
    return res;
}
Console.WriteLine($" = {Sum(Mynum)}");