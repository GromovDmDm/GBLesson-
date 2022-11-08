// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


// void PositiveNumbers()
// {
//     Console.Write("Какое количества чисел вы желиете ввисти: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int count = 0;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите число номер {i + 1} - ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if (num > 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"Вы ввели {count} положительных числа");
// }
// PositiveNumbers();



// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// void IntersectionPoints()  
// {
//     Console.Write("Введите b1: ");
//     double b1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите k1: ");
//     double k1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите b2: ");
//     double b2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите k2: ");
//     double k2 = Convert.ToDouble(Console.ReadLine());

//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;

//     Console.WriteLine($"точка пересечения X - {x}");
//     Console.WriteLine($"точка пересечения Y - {y}");
// }

// IntersectionPoints();