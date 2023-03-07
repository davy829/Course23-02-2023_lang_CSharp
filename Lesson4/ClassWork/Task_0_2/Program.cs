// выводит произведение от одного до введенного числа 
Console.Write("Введите число ___");
int mynum = int.Parse(Console.ReadLine()!);
int Proizvedenie(int num)
{
    int res = 1; // на 0 множить бесполезно поэтому с 1
    for (int i = 0; i < num; i++) //цикл до введенного
    {
        res = res * (i + 1); //считаем произведение
        Console.WriteLine($"{i} x {i+1} = {res} "); //выводим пример
    }
    return res; // вернем результат
}
Console.WriteLine(Proizvedenie(mynum)); // выведем результат