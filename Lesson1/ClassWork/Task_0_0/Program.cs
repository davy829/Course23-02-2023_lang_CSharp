// See https://aka.ms/new-console-template for more information
Console.Write("Введите число и узнайте его квадрат_ ");
int number = int.Parse(Console.ReadLine()!);
int sqear = number * number;       //умножение само на себя
Console.WriteLine($"ответ: {sqear}"); //формат вывода переменной -строка плюс переменная