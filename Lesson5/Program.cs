//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//          Напишите программу, которая покажет количество чётных чисел в массиве.

// int NumberRequest (string s) {
//   Console.Write($"{s}");
//   var stringNumber = Console.ReadLine();
//   int numericValue;
//   bool isNumber = int.TryParse(stringNumber, out numericValue);
//   if (!isNumber) {
//     Console.WriteLine("Вы ввели не число! Программа будет остановлена");
//     System.Environment.Exit(-1);
//     }
//   return numericValue;
// }

// int[] CreateRandomArray(int size, int minVal, int maxVal) 
// {
//   int[] array = new int[size];
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(minVal, maxVal + 1);
//   return array;
// }

// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }

// int EvenNumbers(int[] array) {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++) {
//         if(array[i] % 2 == 0) count++;
//     }
//     return count;
// }
// int[] array = CreateRandomArray(NumberRequest("Введите длину массива "), 100, 999);
// ShowArray(array);
// Console.WriteLine($"Число чётных элементов равно {EvenNumbers(array)}");

//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int NumberRequest (string s) {
//   Console.Write($"{s}");
//   var stringNumber = Console.ReadLine();
//   int numericValue;
//   bool isNumber = int.TryParse(stringNumber, out numericValue);
//   if (!isNumber) {
//     Console.WriteLine("Вы ввели не число! Программа будет остановлена");
//     System.Environment.Exit(-1);
//     }
//   return numericValue;
// }

// int[] CreateRandomArray(int size, int minVal, int maxVal) 
// {
//   int[] array = new int[size];
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(minVal, maxVal + 1);
//   return array;
// }

// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }

// int SumOddPositions(int[] array) {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++) {
//         sum = i % 2 != 0 ? sum + array[i] : sum;
//     }
//     return sum;
// }

// int[] array = CreateRandomArray(NumberRequest("Введите длину массива ")
//                                 , NumberRequest("Введите минимальное значение массива ")
//                                 , NumberRequest("Введите максимальное значение массива "));
// ShowArray(array);
//  Console.WriteLine($"Сумма нечётных элементов массива равна {SumOddPositions(array)}");

//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int NumberRequest (string s) {
//   Console.Write($"{s}");
//   var stringNumber = Console.ReadLine();
//   int numericValue;
//   bool isNumber = int.TryParse(stringNumber, out numericValue);
//   if (!isNumber) {
//     Console.WriteLine("Вы ввели не число! Программа будет остановлена");
//     System.Environment.Exit(-1);
//     }
//   return numericValue;
// }

// double[] CreateArray(int size) 
// {
//   double[] array = new double[size];
//   Console.WriteLine("Creating array: ");
//   for (int i = 0; i < size; i++)
//   {
//     Console.Write($"Введите {i + 1} элемент массива: ");
//     array[i] = Convert.ToDouble(Console.ReadLine());
//   }
//   return array;
// }

// double MaxMinusMin(double[] array) {
//     double max, min;
//     max = min = array[0];
//     for(int i = 1; i < array.Length; i++) {
//         max = max < array[i] ? array[i] : max;
//         min = min > array[i] ? array[i] : min;
//     }
//     return max - min;
    
// }
// Console.WriteLine($"Разница между max и min элемантами равна {MaxMinusMin(CreateArray(NumberRequest("Введите длину массива ")))}");