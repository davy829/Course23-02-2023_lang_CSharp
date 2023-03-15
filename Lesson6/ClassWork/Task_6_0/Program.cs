// конвертирует из 10 в двоичную
Console.Write("Введите размер массива_");
int Size = int.Parse(Console.ReadLine()!);


string Convert2(int num)
{
    string ost = "";
    while (num > 0)
    {
        ost = num % 2 + ost;
        num = num / 2;
        }
    return ost;
}

string myconv = Convert2(Size);
Console.Write($"{Size} in BIN system is: {myconv} ");