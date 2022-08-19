/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Первое число равно " + a + ", второе число равно " + b + ", третье число равно " + c + ".");

if (a > b && a > c) {
    Console.WriteLine("Самое большое число из всех первое и равно " + a + ".");
} else if (b > a && b > c) {
    Console.WriteLine("Самое большое число из всех второе и равно " + b + ".");
} else if (c > a && c > b) {
    Console.WriteLine("Самое большое число из всех третье и равно " + c + ".");
} else {
    Console.WriteLine("Некоторые из введённых чисел равны, невозможно определить единственное максимальное!");
}

Console.Write("Программа завершена успешно.");


