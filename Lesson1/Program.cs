// Задача №1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// void Max (int a, int b) {
//     int max = a > b ? a : b;
//     Console.Write($"Max = {max}");
// }

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Max(a,b);

// Задача №2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// int Max (int a, int b) {
//     int max = a > b ? a : b;
//     return max;
// }

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = Max(a,b);
// max = Max(max,c);

// Console.Write($"Max = {max}");

// Задача №3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// bool Even(int num) {
//     if(num % 2 == 0) {
//         return true;
//     } else {
//         return false;
//     }
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// String EvenNum = Even(num) == true ? "чётное" : "не чётное";
// Console.Write($"Ваше число {EvenNum}");

// Задача №4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// void Even(int num) {
//     if(num >= 2) {
//         Console.Write("Чётные числа: ");
//         for(int i = 1; i <= num; i++) {           
//             if(i % 2 ==0)
//                 Console.Write(i + " ");
//         }
//     } else {
//         Console.Write("Чётных чисел нет");
//     }
// }

// Console.Write("Введите число N: ");
// Even(Convert.ToInt32(Console.ReadLine()));