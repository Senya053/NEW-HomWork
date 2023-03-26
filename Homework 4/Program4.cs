// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int exponentiation = a;

// for (int i = 1; i < b; i++)
// {
// exponentiation = exponentiation * a;
// }
// Console.WriteLine("A ^ B = " + exponentiation);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// Console.WriteLine("Создадим массив длиной A в диапвзоне 0-A");
// Console.Write("Введите число (A): ");
// int enterNumber = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[enterNumber];
//     for (int i = 0; i < enterNumber; i++)
//     {
//     array[i] = new Random().Next(enterNumber+1);
//     Console.Write(array[i] + "; ");
//     }
// Console.Write("-> ");
// void Outputs (int[] array)
// {
//     Console.Write("[");
//      for(int i = 0; i < array.Length; i++)
//      {
//          Console.Write ( array[i] + "; ");
//      }
//      Console.WriteLine("]");
// }
// Outputs(array);