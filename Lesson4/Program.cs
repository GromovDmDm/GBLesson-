//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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

// int Exponentiation(int a, int b) {
//     int exp = 1;
//     for(int i = 0; i < b; i++) {
//         exp *= a;
//     }
//     return exp;
// }

// int a = NumberRequest("Введите число А: ");
// int b = NumberRequest("Введите число B: ");
// Console.WriteLine($"А в степени В равно {Exponentiation(a,b)}");

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
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

// int SumElement(int num){
//     int sum = 0;
//     num = Math.Abs(num);
//     while (num > 0) {
//         sum += num % 10;
//         num /= 10;
//     }
//     return sum;
// }

// Console.WriteLine($"Сумма цифр в числе равна {SumElement(NumberRequest("Введите число: "))}");

// Задача 3: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

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

// ShowArray(CreateRandomArray(NumberRequest("Введите длину массива ")
//                             ,NumberRequest("Введите минимальный размер элемента массива ")
//                             ,NumberRequest("Введите максимальный размер элеманта массива ")));