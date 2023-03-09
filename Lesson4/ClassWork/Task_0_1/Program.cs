// See https://aka.ms/new-console-template for more information
Console.Write("ВВедите число , покажет сколько знаков _");
int number7 = int.Parse(Console.ReadLine()!);

int HowMutchNum(int num)
{
    int length = 6;
    int res = 0;
    for (int i = 0; num > 0; i++)
    {
       num = num / 10;
       res++;
    }
    return res;
}

int resault = HowMutchNum(number7);
Console.WriteLine($"in {number7} number {resault}");
