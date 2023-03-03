	// 3. Напишите программу, которая принимает на вход число и проверяет,
	//    кратно ли оно одновременно 7 и 23.
Console.Write("input number _");
int number = int.Parse(Console.ReadLine()!);

void Krat7Krat23(int Num)
{
   if (Num % 7 == 0 & Num % 23 == 0)
   {
    Console.WriteLine("kratnoe !!");
   }
   else
   {
    Console.WriteLine("no kratnoe !!");
   }
}


Krat7Krat23(number);