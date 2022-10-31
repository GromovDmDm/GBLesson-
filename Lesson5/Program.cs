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