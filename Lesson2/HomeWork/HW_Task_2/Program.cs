// из трехзначного числа удалит вторую цифру
int SecondNum(int MyNum)
{
    int firstNum = MyNum / 100 * 10; // делим трехзнак на 100 множим на 10 -- (235 / 100 *10 = 20)
    int SecNum = firstNum +( MyNum % 10); // результат первой плюс остаток от деления на 10 -- третья цифра
    return  SecNum ;
    
}

int num = new Random().Next(100,999); // произвольное трехзначное
Console.WriteLine($"Our num :  {num}"); // выводим свое произвольное
int resault = SecondNum(num);  // ловим результат функции в резаулт
Console.WriteLine($"вторая цифра :  {resault}"); 