//Задача №1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int NumberRequest (string s) { //Метод получения числа для последующих задач (В данной задаче -1 пойдёт, дальше буду стопить)
//   Console.Write($"{s}");
//   var stringNumber = Console.ReadLine();
//   int numericValue;
//   bool isNumber = int.TryParse(stringNumber, out numericValue);
//   return isNumber ? numericValue : -1;
// }

// String IsPalindrome(int num) {
//   int revertedNumber = 0;
//   while(num > revertedNumber) {
//     revertedNumber = revertedNumber * 10 + num % 10;
//     num /= 10;
//   }
//   return num == revertedNumber || num == revertedNumber / 10 ? "палиндром" : "не палиндром";
// }

// int TestFiveDigits(int count) { // Поигрался с рекурсией
//   int num = Math.Abs(NumberRequest("Введите пятизначное число: "));
//   if(num < 10000 || num > 99999) {
//     count++;
//     if(count > 2) {
//       Console.WriteLine("Вы ввели три раза не верное число! Программа будет остановлена!!!");
//       System.Environment.Exit(-1);
//     }
//     TestFiveDigits(count);
//   }
//   return num;
// }

// int count = 0;
// Console.WriteLine($"Ваше число {IsPalindrome(TestFiveDigits(count))}");

//Задача №2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double NumberRequest (string s) {
//   Console.Write($"{s}");
//   var stringNumber = Console.ReadLine();
//   double numericValue;
//   bool isNumber = double.TryParse(stringNumber, out numericValue);
//   if (!isNumber) {
//     Console.WriteLine("Вы ввели не число! Программа будет остановлена");
//     System.Environment.Exit(-1);
//     }
//   return numericValue;
// }
// double x1 = NumberRequest("Введите координату x точки A: ");
// double y1 = NumberRequest("Введите координату y точки A: ");
// double z1 = NumberRequest("Введите координату z точки A: ");
// double x2 = NumberRequest("Введите координату x точки B: ");
// double y2 = NumberRequest("Введите координату y точки B: ");
// double z2 = NumberRequest("Введите координату z точки B: ");

// double findDiscord(double x1, double y1, double z1
//                 , double x2, double y2, double z2) {
//   return Math.Sqrt(Math.Pow((x2-x1), 2) 
//                    + Math.Pow((y2-y1), 2)
//                    + Math.Pow((z2-z1), 2));
// }

// double distance =  Math.Round(findDiscord(x1, y1, z1, x2, y2, z2), 2 );

// Console.WriteLine($"Длина равна  {distance}");

//Задача №3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

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

// void CubeArray(int[] array, int n) {
//   if(n > 0) {
//     for(int i = 1; i < array.Length; i++) {
//       array[i] = Convert.ToInt32(Math.Pow(i,3));
//     }
//   } else {
//      for(int i = 1, j = 1; i >= n; i--, j++) {  //обратная обработка
//       array[j] = Convert.ToInt32(Math.Pow(i,3));
//     }   
//   }
// }

// void ShowArray(int[] array) {
//   for(int i = 1; i < array.Length; i++) {
//     Console.Write($"{array[i]} ");
//   }
// }
// int n = NumberRequest("Введите число N ");
// int[] array = new int[ Math.Abs(n) + 1];
// if (n < 1) Array.Resize(ref array, array.Length + 2); //Добавил тут, т.к. Resize возвращает ссылку на новый массив. Пришлось бы с метода убирать void, я этого не хотел
// CubeArray(array, n);
// ShowArray(array);
