//  Напишите цикл, который принимает на вход
//  два числа (A и B) и возводит число A в натуральную
//   степень B.
 //  ДВА ВАРИАНТА РЕШЕНИЯ !!!
Console.Write("Введите два числа , первое возведем в степень второго __");
double FirstNum = double.Parse(Console.ReadLine()!);
double SecondNum = double.Parse(Console.ReadLine()!);


//-----------------------------------------------------------------
//считает формула
double NaturalDegreeCirkle(double FNum1, double SNum2) 
{
    double res2 = FNum1;
    for (int i = 1; i < SNum2; i++)
    {
     res2 = res2 * FNum1; 
     Console.WriteLine($"{FNum1} x {res2} = {res2 * FNum1}  ");
    }
    return res2;
}
double resault = NaturalDegreeCirkle(FirstNum, SecondNum);
Console.Write($"{FirstNum} in degree {SecondNum} = {resault}");