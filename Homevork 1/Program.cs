// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num2 < num1)
// {
//     Console.WriteLine($"first namber {num1} = MAX, {num2} = MIN");
// }
// else 
// {
//     Console.WriteLine($"second namber {num2} = MAX, {num1} = MIN");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное 
// из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int MAX;
// if(num2 < num1)
// {
//    MAX = num1;
//    if(MAX < num3)
//    {
//     MAX = num3;
//    }
//    Console.WriteLine($"namber {MAX} = MAX");
// }
// else 
// {
//     MAX = num2;
//    if(MAX < num3)
//    {
//     MAX = num3;
//    }
//    Console.WriteLine($"namber {MAX} = MAX");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Input first number");
// int i = Convert.ToInt32(Console.ReadLine());
// if (i % 2 == 0)
// {
//     Console.WriteLine($"number {i} -> even");
// }
// else 
// {
//     Console.WriteLine($"number {i} -> not even");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine()); 
// for(int i=1;i<=n;i++)
// if (i % 2 == 0)
// {
// System.Console.Write(i + ",");
// }
// if(n <= 1)
// {
//     System.Console.Write("Please enter a number greater than 1");
// }
