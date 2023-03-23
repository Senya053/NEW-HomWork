// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// 1 VAR

// Console.WriteLine("Input five-digit number"); 
// string number = Console.ReadLine();
// int digit = number.Length;
// if (digit == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - palindrome");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - no palindrome");
//     }
// }
// else
// {
//     Console.WriteLine($"{number} - no five-digit number");
// }

// 2 VAR

// Console.WriteLine("Input five-digit number"); 
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >9999 && number <100000)
// {
//     if (number/10000%10 == number%10 && number/1000%10 == number/10%10)
//     {
//         Console.WriteLine($"{number} - palindrome");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - no palindrome");
//     }
// }
// else
// {
//     Console.WriteLine($"{number} - no five-digit number");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Round(Math.Sqrt((Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2))+Math.Pow(z2-z1,2)), 3);
// }

// Console.WriteLine("Input X1 of A: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Y1 of A: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Z1 of C: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input X1 of B: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Y1 of B: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Z2 of B: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double distance = FindDistance(x1, y1, z1, x2, y2, z2);
// Console.WriteLine($"Distanse between A and B is {distance}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел
// от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Power(double N)
// {
//     double i = 1;
//     while(i<=N)
//     {
//          Console.WriteLine($"{i} -> {i}^3 -> {Math.Pow(i, 3)}");
//          i++;
//     }
// }
// Console.WriteLine("Input the number N:");
// double N = Convert.ToDouble(Console.ReadLine());
// Power(N);
