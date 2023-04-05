// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными 
//числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] Create2DRandomArray (int rows, int columns, double minValue, double maxValue)
{
    double[,] myArray = new double[rows, columns];
    for(int i = 0; i < rows;i++)
    {
        for(int j = 0; j < columns;j++)
        {
            myArray[i,j] = Convert.ToDouble(new Random().Next((int)minValue, (int)(maxValue + 1)));
        }
    }
return myArray;
}
void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[minValue, maxValue];
Create2DRandomArray(rows, columns, minValue, maxValue);
PrintArray2D(numbers);

// 1 2 3
// 4 5 6
// 7 8 9

// void Show2DArray (double[,] muArray)
// {
//     for(int i = 0; i < muArray.GetLength(0);i++)
//     {
//         for(int j = 0; j < muArray.GetLength(1);j++)
//         {
//             Console.Write(muArray[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DRandomArray(rows, columns, minValue, maxValue));

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.