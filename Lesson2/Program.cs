// Задача №1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int GetNumber (int number) {
//     if (number < 100 || number > 999) return -1;
//     return (number / 10) % 10;
// }

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int getNum = GetNumber(Math.Abs(num));
// if (getNum == -1) Console.Write("Вы ввели не трёхзначное число!");
// else Console.Write($"Вторая цифра равно: {getNum}");

// Задача №2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int GetThirdNumber (int number) {
//     if(number < 100) return -1;

//     while(number >= 1000) {
//         number /= 10;
//     }
//     return number % 10;
// }

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int thirdNumber = GetThirdNumber(Math.Abs(number));
// if(thirdNumber == -1)
//     Console.Write("Третьей цифры нет!");
// else
//     Console.Write($"Третье число равно: {thirdNumber}");

// Задача №3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// String DayOff (int num) {
//     if(num > 0 && num < 8) {
//         if(num > 5) return "Выходной";
//         else return "Будний день";
//     } else return "Цифра не подходит под день недели";
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write(DayOff(number));
