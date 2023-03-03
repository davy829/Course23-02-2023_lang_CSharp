// принимаем число от него до еденицы выводим куб каждого элемента
Console.Write("Введите число___");
int MyNum = int.Parse(Console.ReadLine()!);

void TableSquare(int n)
{
    int i = 1; // счетчик + 1
     while (n >= i)  // пока счетчик не вырос до введенного польз числа делаем
     {
        Console.WriteLine($"{i} ->  {Math.Pow(i,3)}, "); //элемент -> третья степень элемента
        i++;  // счетчик увеличиваем на один
     }
}
TableSquare(MyNum); // вызываем функцию
