// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         if(minValue<100&maxValue>999) 
//         Console.WriteLine($"вы ввели не трёхзначное или отрицательное число");
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
// void EvenNumber (int[] array)
// {
//     int n=0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] %2==0) 
//         n ++;
//     }

//     Console.WriteLine ($"количество чётных чисел-> {n}");
// }


// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Enter the minimum three-digit value of the array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Enter the maxmum three-digit value of the array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray (myArray);

// EvenNumber (myArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
// void FindSum (int[] array)
// {
//     int sum = 0;
//         for(int i = 1; i < array.Length; i+=2)
//     {
//         sum += array[i];
//     }

//     Console.WriteLine ($"Cумма элементов,стоящих на нечётных позициях -> {sum}");
// }
// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray (myArray);
// FindSum (myArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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
// void Difference (int[] array)
// {
//     int m = 0;
//     int max=array[0];
//     int min=array[0];
//         for(int i = 0; i < array.Length; i++)
//     {
//        if(array[i]<min) min=array[i];
//        if(array[i]>max) max=array[i];    
//        m=max-min;
//     }

//     Console.WriteLine ($"разницу между максимальным и минимальным элементов массива -> {m}");
// }
// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray (myArray);
// Difference (myArray);
