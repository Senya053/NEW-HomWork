// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Input number3digit"); 
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >99 && num <1000)
// {
//     int i=(num/10%10);
//     Console.WriteLine($"seconddigit {i}");
// }
// else
// System.Console.WriteLine("no number3digit");

// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Input number digit"); 
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >99)
//  {
//      int i=(num/100%10);
//      Console.WriteLine($"third digit {i}");
//  }
//  else
//  System.Console.WriteLine("No third digit");

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// int dayNumber = ReadInt("Input number from 1 to 7: ");
// Console.WriteLine(WorkHoliday(dayNumber));

// int ReadInt(string message)
//  	{
//  	Console.Write(message);
//  	return Convert.ToInt32(Console.ReadLine());
//  	}
//  	string WorkHoliday(int a)
//  	{
//  	if (a > 0 && a < 8)
//  	{
//  	if (a == 7 || a == 6)
//  	{
//  	Console.Write($"{a} - day off");
//  	}
//  	else
//  	{
//  	Console.Write($"{a} - working day");
//  	}
//  	}
//  	else
//  	{
//  	Console.Write($"number {a} not a day of the");
//  	}
//  	return " week.";
//  	}