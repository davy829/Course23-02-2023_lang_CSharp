// проверяет ввод из пяти знаков полиндром или нет
Console.Write("Введите пятизначное число, только честно, мы проверим !! _");
int Polindrom = int.Parse(Console.ReadLine()!);
void PolOrNo(int MyNum)
{
    if (MyNum < 99999 )   if (MyNum > 9999)  // проверит точно пять знаков
    {
        int num1 = MyNum / 10000;  // 12321 / 10000 = 1 - первая цифра
        int num5 = MyNum % 10;     // 12321 % 10 = 1 пятая цифра
        int num2 = MyNum / 1000 % 10;  // 12321 / 1000 = 12 % 10 = 2 вторая  цифра
        int num4 = MyNum % 100 / 10; // 12321 % 100 = 21 / 10 = 2 чет вертая
        if (num1 == num5 && num2 == num4) // проверяяем равна ли 1 == 5, 2 == 4 если да
        {
            Console.WriteLine($"{MyNum} is Polindrom xa! ");
        }
        else
        {
            Console.WriteLine($"{num1} <> {num5} ");
            Console.WriteLine($"{num2} <> {num4} ");
            Console.Write($"{MyNum} is no Polindrom xa! ");
        }
    }    
    else
    {
    Console.WriteLine($"Так дело не пойтет !  надо пять знаков ! Вы ввели {MyNum}");     
    }    
}
PolOrNo(Polindrom);