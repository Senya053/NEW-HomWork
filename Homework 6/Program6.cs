﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }
// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }
// void PositiveNum (int[] array)
// {
//     int num=0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>=0) num++;
//     }
//     Console.Write (num);
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray (myArray);
// PositiveNum (myArray);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine ("Input b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());

// void IntersectionPoint (double b1, double k1, double b2, double k2)
// { 
//     double x;
//     double y;
//     x = (b2-b1)/(k1-k2);
//     y = k1 * x + b1;
//     x=Math.Round(x,3);
//     y=Math.Round(y,3);
//     Console.WriteLine($"точка пересечения -> ({x};{y})");
// }

// IntersectionPoint (b1, k1, b2, k2);
